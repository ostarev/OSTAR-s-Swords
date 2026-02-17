using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class Dawn : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 64;
		Item.height = 64;
		Item.scale = 1f;
		Item.rare = ItemRarityID.LightRed;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 20;
		Item.useAnimation = 20;
		Item.damage = 23;
		Item.knockBack = 7f;
		Item.UseSound = SoundID.Item1;
		Item.value = Item.sellPrice(0, 0, 16, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.Feather, 30);
		recipe.AddRecipeGroup("IronBar", 10);
		recipe.AddIngredient(Mod, "SwordMatter", 50);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
	}
}
