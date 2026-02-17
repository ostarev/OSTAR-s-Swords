using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class BiggoronSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 32;
		Item.height = 32;
		Item.scale = 1.9f;
		Item.rare = ItemRarityID.Green;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 40;
		Item.useAnimation = 40;
		Item.damage = 30;
		Item.knockBack = 2f;
		Item.UseSound = SoundID.Item1;
		Item.value = 19000;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddRecipeGroup("IronBar", 10);
		recipe.AddIngredient(ItemID.GoldBar, 10);
		recipe.AddIngredient(Mod, "SwordMatter", 60);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
		Recipe recipe2 = CreateRecipe();
		recipe2.AddRecipeGroup("IronBar", 10);
		recipe2.AddIngredient(ItemID.PlatinumBar, 10);
		recipe2.AddIngredient(Mod, "SwordMatter", 60);
		recipe2.AddTile(TileID.Anvils);
		recipe2.Register();
	}
}
