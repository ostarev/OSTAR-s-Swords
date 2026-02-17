using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items;

public class LunarOrb : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 40;
		Item.height = 40;
		Item.maxStack = 999;
		Item.value = 700000;
		Item.rare = ItemRarityID.Cyan;
		Item.ResearchUnlockCount = 25;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.FragmentSolar, 10);
		recipe.AddIngredient(ItemID.FragmentVortex, 10);
		recipe.AddIngredient(ItemID.FragmentNebula, 10);
		recipe.AddIngredient(ItemID.FragmentStardust, 10);
		recipe.AddIngredient(ItemID.SoulofLight, 15);
		recipe.AddIngredient(ItemID.SoulofNight, 15);
		recipe.AddIngredient(ItemID.SoulofFlight, 15);
		recipe.AddIngredient(ItemID.SoulofMight, 20);
		recipe.AddIngredient(ItemID.SoulofFright, 20);
		recipe.AddIngredient(ItemID.SoulofSight, 20);
		recipe.AddIngredient(Mod, "MartianSaucerCore", 1);
		recipe.AddIngredient(ItemID.CelestialSigil, 1);
		recipe.AddTile(TileID.LunarCraftingStation);
		recipe.Register();
	}
}
