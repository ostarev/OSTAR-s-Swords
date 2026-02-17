using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class FreezeFireClaw : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 48;
		Item.height = 56;
		Item.scale = 1f;
		Item.rare = ItemRarityID.LightPurple;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 20;
		Item.useAnimation = 20;
		Item.damage = 50;
		Item.knockBack = 7f;
		Item.UseSound = SoundID.Item1;
		Item.value = Item.sellPrice(0, 5, 0, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void MeleeEffects(Player player, Rectangle hitbox)
	{
		if (Main.rand.Next(2) == 0)
		{
			int dust = Dust.NewDust(new Vector2((float)hitbox.X, (float)hitbox.Y), hitbox.Width, hitbox.Height, DustID.DungeonSpirit, 0f, 0f, 100, default(Color), 2f);
			Main.dust[dust].noGravity = true;
			Main.dust[dust].velocity.X += (float)player.direction * 0f;
			Main.dust[dust].velocity.Y += 0f;
			dust = Dust.NewDust(new Vector2((float)hitbox.X, (float)hitbox.Y), hitbox.Width, hitbox.Height, DustID.Torch, 0f, 0f, 100, default(Color), 2f);
			Main.dust[dust].noGravity = true;
			Main.dust[dust].velocity.X += (float)player.direction * 0f;
			Main.dust[dust].velocity.Y += 0f;
		}
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "OrangeRuneSword", 1);
		recipe.AddIngredient(Mod, "BlueRuneBlade", 1);
		recipe.AddIngredient(ItemID.LivingFireBlock, 25);
		recipe.AddIngredient(ItemID.IceBlock, 150);
		recipe.AddIngredient(Mod, "SwordMatter", 170);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.OnFire, 360, false);
		target.AddBuff(BuffID.Frostburn, 360, false);
	}
}
