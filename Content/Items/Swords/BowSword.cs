using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class BowSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 32;
		Item.height = 32;
		Item.scale = 1.1f;
		Item.rare = 3;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 25;
		Item.useAnimation = 25;
		Item.damage = 24;
		Item.knockBack = 5f;
		Item.UseSound = SoundID.Item5;
		Item.shootSpeed = 10f;
		Item.value = Item.sellPrice(0, 0, 50, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
		Item.shoot = 10;
		Item.useAmmo = AmmoID.Arrow;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(39, 1);
		recipe.AddRecipeGroup("IronBar", 15);
		recipe.AddIngredient(Mod, "SwordMatter", 60);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
	}
}
