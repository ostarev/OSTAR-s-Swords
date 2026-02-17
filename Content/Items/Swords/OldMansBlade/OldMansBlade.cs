using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;
using OSTARsSWORDS.Rarities;
using Terraria.DataStructures;
using OSTARsSWORDS.Content.Players;

namespace OSTARsSWORDS.Content.Items.Swords.OldMansBlade;

public class OldMansBlade : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 48;
		Item.height = 48;
		Item.scale = 1.5f;
		Item.rare = ModContent.RarityType<Inferno>();
		Item.useTime = 30;
		Item.useAnimation = 30;
		Item.damage = 87;
		Item.knockBack = 7f;
		Item.UseSound = SoundID.Item18;

		Item.value = 180500;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
		Item.useStyle = ItemUseStyleID.Swing;
    }

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "AllWoodSword", 1);
		recipe.AddIngredient(ItemID.SpookyWood, 99);
		recipe.AddIngredient(ItemID.Pearlwood, 81);
		recipe.AddIngredient(Mod, "Orichalcon", 1);
		recipe.AddIngredient(Mod, "SwordMatter", 100);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}

    public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
    {
        target.AddBuff(BuffID.Darkness, 1800);
		SoundEngine.PlaySound(new SoundStyle("OSTARsSWORDS/Sounds/Hit") { Volume = 0.5f }, player.position);

        // track consecutive hits with this weapon and apply damage on every 10th hit
        var modPlayer = player.GetModPlayer<OldMansBladePlayer>();
		modPlayer.OldManBladeConsecutiveHits++;

		if (modPlayer.OldManBladeConsecutiveHits % 10 == 0)
		{
			int bonusDamage = (int)(target.lifeMax * 0.01f);
			if (bonusDamage < 500) bonusDamage = Main.rand.Next(300, 500) + (int)(damageDone * 1.2f);

			SoundEngine.PlaySound(new SoundStyle("OSTARsSWORDS/Sounds/OldManHit") 
			{ 
				Volume = 1.2f,
				Pitch = 0.2f,
				PitchVariance = 1.0f
			}, target.position);

			NPC.HitInfo extraHit = new NPC.HitInfo();
			extraHit.Damage = bonusDamage;
			extraHit.HitDirection = player.direction;
			extraHit.Crit = false;
			
			target.StrikeNPC(extraHit);
			player.addDPS(bonusDamage);

            // Awakened Hit Text
            CombatText.NewText(target.getRect(), Color.Turquoise, bonusDamage.ToString() + "!!", true);
		} else if(modPlayer.OldManBladeConsecutiveHits % 10 == 9) { // Awakening sound
			SoundEngine.PlaySound(new SoundStyle("OSTARsSWORDS/Sounds/OldManAwakened") 
			{ 
				Volume = 1.2f,	
				Pitch = 0.2f
			}, target.position);
		}

		// Pre Awakening effect
		modPlayer.IsAwakened = (modPlayer.OldManBladeConsecutiveHits % 10 == 9);
    }

	public override void HoldItem(Player player)
	{
		Item.noUseGraphic = false;
	}

	// Draw the awakened sprite on top of the original with transparency in the inventory
	public override void PostDrawInInventory(SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale)
	{
		float alpha = Main.LocalPlayer.GetModPlayer<OldMansBladePlayer>().AwakenedAlpha;
		if (alpha > 0f)
		{
			Texture2D texture = ModContent.Request<Texture2D>("OSTARsSWORDS/Content/Items/Swords/OldMansBlade/OldMansAwakened").Value;
			
			// Pulse effect based on time
			float pulse = (float)System.Math.Sin(Main.GlobalTimeWrappedHourly * 15f) * 0.2f + 0.8f;
			
			// Regular draw
			spriteBatch.Draw(texture, position, null, drawColor * alpha, 0f, texture.Size() / 2f, scale, SpriteEffects.None, 0f);
			
			// Additive glow pass (Flaming look)
			spriteBatch.Draw(texture, position, null, Color.Orange * alpha * pulse * 0.6f, 0f, texture.Size() / 2f, scale * (1f + pulse * 0.05f), SpriteEffects.None, 0f);
		}
	}

    // Spawn some fancy dust while swinging
    public override void MeleeEffects(Player player, Rectangle hitbox)
    {
		var modPlayer = player.GetModPlayer<OldMansBladePlayer>();
        int dustCount = modPlayer.AwakenedAlpha > 0.5f ? Main.rand.Next(6, 12) : Main.rand.Next(3, 9);
        Vector2 corner = new Vector2(hitbox.X + hitbox.Width / 6, hitbox.Y);		
        for (int i = 0; i < dustCount; ++i)
        {
            int dustID;
			// If awakened, use fire and heavy orange dust
			if (modPlayer.AwakenedAlpha > 0.5f)
			{
				dustID = Main.rand.NextBool() ? DustID.SolarFlare : DustID.Torch;
			}
			else
			{
				switch (Main.rand.Next(5))
				{
					case 0:
					case 1:
						dustID = 269; // Ancient/Sand Brown
						break;
					case 2:
						dustID = 158; // Bright Orange/Yellow
						break;
					default:
						dustID = 64; // Yellow Sparkle
						break;
				}
			}
            int idx = Dust.NewDust(corner, hitbox.Width / 2, hitbox.Height / 2, dustID);
            Main.dust[idx].noGravity = true;
			if (modPlayer.AwakenedAlpha > 0.5f) {
				Main.dust[idx].scale = 1.2f;
				Main.dust[idx].velocity *= 1.5f;
			}
        }
    }
}

public class OldMansBladeHeldLayer : PlayerDrawLayer
{
	public override Position GetDefaultPosition() => new AfterParent(PlayerDrawLayers.HeldItem);

	public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
	{
		return drawInfo.drawPlayer.HeldItem.type == ModContent.ItemType<OldMansBlade>() && 
			   drawInfo.drawPlayer.itemAnimation > 0 &&
			   drawInfo.drawPlayer.GetModPlayer<OldMansBladePlayer>().AwakenedAlpha > 0f;
	}

	protected override void Draw(ref PlayerDrawSet drawInfo)
	{
		Player drawPlayer = drawInfo.drawPlayer;
		Item item = drawPlayer.HeldItem;
		float alpha = drawPlayer.GetModPlayer<OldMansBladePlayer>().AwakenedAlpha;

		Texture2D texture = ModContent.Request<Texture2D>("OSTARsSWORDS/Content/Items/Swords/OldMansBlade/OldMansAwakened").Value;
		
		Vector2 position = new Vector2((int)(drawInfo.ItemLocation.X - Main.screenPosition.X), (int)(drawInfo.ItemLocation.Y - Main.screenPosition.Y));
		Rectangle frame = texture.Bounds;
		
		// For Swing style, the origin is usually the bottom-left/bottom-right depending on direction
		Vector2 origin = new Vector2(drawPlayer.direction == -1 ? frame.Width : 0, frame.Height);

		// Regular Draw
		DrawData data = new DrawData(
			texture,
			position,
			frame,
			item.GetAlpha(drawInfo.itemColor) * alpha,
			drawPlayer.itemRotation,
			origin,
			item.scale,
			drawPlayer.direction == -1 ? SpriteEffects.FlipHorizontally : SpriteEffects.None,
			0
		);
		drawInfo.DrawDataCache.Add(data);

		// Pulsing Glow (Additive Draw)
		float pulse = (float)System.Math.Sin(Main.GlobalTimeWrappedHourly * 15f) * 0.2f + 0.8f;
		DrawData glowData = new DrawData(
			texture,
			position,
			frame,
			Color.Orange * alpha * pulse * 0.6f, // Soft orange glow
			drawPlayer.itemRotation,
			origin,
			item.scale * (1f + pulse * 0.05f), // Slightly larger for "aura" look
			drawPlayer.direction == -1 ? SpriteEffects.FlipHorizontally : SpriteEffects.None,
			0
		);
		drawInfo.DrawDataCache.Add(glowData);
	}
}
