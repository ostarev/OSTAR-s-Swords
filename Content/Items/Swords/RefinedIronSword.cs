using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class RefinedIronSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 58;
		Item.height = 60;
		Item.scale = 1f;
		Item.rare = ItemRarityID.Green;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 20;
		Item.useAnimation = 20;
		Item.damage = 15;
		Item.knockBack = 6f;
		Item.UseSound = SoundID.Item1;
		Item.value = Item.buyPrice(0, 0, 30, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddRecipeGroup("IronBar", 5);
		recipe.AddIngredient(ItemID.IronBroadsword, 1);
		recipe.AddIngredient(Mod, "SwordMatter", 20);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
		Recipe recipe2 = CreateRecipe();
		recipe2.AddRecipeGroup("IronBar", 5);
		recipe2.AddIngredient(ItemID.LeadBroadsword, 1);
		recipe2.AddIngredient(Mod, "SwordMatter", 20);
		recipe2.AddTile(TileID.Anvils);
		recipe2.Register();
	}
}
