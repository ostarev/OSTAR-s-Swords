using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class Destructor : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 35;
		Item.height = 35;
		Item.scale = 1.9f;
		Item.rare = 6;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 15;
		Item.useAnimation = 15;
		Item.damage = 68;
		Item.knockBack = 10f;
		Item.UseSound = SoundID.Item1;
		Item.value = 290000;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(482, 1);
		recipe.AddIngredient(Mod, "SwordShard", 1);
		recipe.AddIngredient(Mod, "UpgradeMatter", 1);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
		Recipe recipe2 = CreateRecipe();
		recipe2.AddIngredient(1199, 1);
		recipe2.AddIngredient(Mod, "SwordShard", 1);
		recipe2.AddIngredient(Mod, "UpgradeMatter", 1);
		recipe2.AddTile(TileID.MythrilAnvil);
		recipe2.Register();
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.Venom, 360, false);
	}
}
