using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items;

public class SwordShard : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 20;
		Item.height = 20;
		Item.maxStack = 999;
		Item.value = 0;
		Item.rare = ItemRarityID.LightRed;
		Item.ResearchUnlockCount = 25;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "SwordMatter", 400);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
	}
}
