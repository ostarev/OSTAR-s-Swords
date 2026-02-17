using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Materials;

public class Orichalcon : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 32;
		Item.height = 32;
		Item.maxStack = 999;
		Item.value = 180000;
		Item.rare = ItemRarityID.LightPurple;
		Item.ResearchUnlockCount = 25;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.HallowedBar, 1);
		recipe.AddIngredient(ItemID.SoulofLight, 1);
		recipe.AddIngredient(ItemID.SoulofNight, 1);
		recipe.AddIngredient(ItemID.PixieDust, 10);
		recipe.AddIngredient(Mod, "SwordMatter", 80);
		recipe.AddIngredient(ItemID.FrostCore, 1);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}
}
