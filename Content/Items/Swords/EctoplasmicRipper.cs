using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class EctoplasmicRipper : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.damage = 72;
		Item.crit = 2;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
		Item.width = 54;
		Item.height = 54;
		Item.useTime = 15;
		Item.useAnimation = 15;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.knockBack = 6f;
		Item.value = Item.sellPrice(0, 15, 0, 0);
		Item.rare = ItemRarityID.Cyan;
		Item.scale = 1f;
		Item.UseSound = SoundID.Item103;
		Item.autoReuse = true;
		Item.useTurn = true;
	}

	public override void MeleeEffects(Player player, Rectangle hitbox)
	{
		if (Main.rand.Next(1) == 0)
		{
			int dust = Dust.NewDust(new Vector2((float)hitbox.X, (float)hitbox.Y), hitbox.Width, hitbox.Height, DustID.MagicMirror, 0f, 0f, 100, default(Color), 2f);
			Main.dust[dust].noGravity = true;
		}
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.Ectoplasm, 15);
		recipe.AddIngredient(ItemID.SpectreBar, 10);
		recipe.AddIngredient(Mod, "DeathSword", 1);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		int healingAmt = damageDone / 8;
		player.statMana += healingAmt;
		player.HealEffect(healingAmt, true);
	}
}
