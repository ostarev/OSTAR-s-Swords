using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class OrcWarSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 32;
		Item.height = 32;
		Item.scale = 1.9f;
		Item.rare = 4;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 55;
		Item.useAnimation = 55;
		Item.damage = 45;
		Item.knockBack = 6f;
		Item.UseSound = SoundID.Item1;
		Item.value = 29000;
		Item.autoReuse = false;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(22, 25);
		recipe.AddIngredient(Mod, "BiggoronSword", 1);
		recipe.AddIngredient(Mod, "SwordMatter", 70);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
		Recipe recipe2 = CreateRecipe();
		recipe2.AddIngredient(704, 25);
		recipe2.AddIngredient(Mod, "BiggoronSword", 1);
		recipe2.AddIngredient(Mod, "SwordMatter", 70);
		recipe2.AddTile(TileID.Anvils);
		recipe2.Register();
	}
}
