using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using OSTARsSWORDS.Content.Projectiles;

namespace OSTARsSWORDS.Content.Items.Swords;

public class PoisonCrystallus : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 44;
		Item.height = 54;
		Item.scale = 1f;
		Item.rare = ItemRarityID.Orange;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 25;
		Item.useAnimation = 25;
		Item.damage = 22;
		Item.knockBack = 6f;
		Item.shoot = ModContent.ProjectileType<Poison>();
		Item.shootSpeed = 10f;
		Item.UseSound = SoundID.Item1;
		Item.value = Item.sellPrice(0, 2, 0, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void MeleeEffects(Player player, Rectangle hitbox)
	{
		if (Main.rand.Next(2) == 0)
		{
			int dust = Dust.NewDust(new Vector2((float)hitbox.X, (float)hitbox.Y), hitbox.Width, hitbox.Height, DustID.JungleGrass, 0f, 0f, 100, default(Color), 2f);
			Main.dust[dust].noGravity = true;
		}
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "CorruptCrystallus", 1);
		recipe.AddIngredient(ItemID.Stinger, 14);
		recipe.AddIngredient(ItemID.JungleSpores, 9);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
		Recipe recipe2 = CreateRecipe();
		recipe2.AddIngredient(Mod, "CrimsonCrystallus", 1);
		recipe2.AddIngredient(ItemID.Stinger, 14);
		recipe2.AddIngredient(ItemID.JungleSpores, 9);
		recipe2.AddTile(TileID.Anvils);
		recipe2.Register();
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.Poisoned, 300, false);
	}
}
