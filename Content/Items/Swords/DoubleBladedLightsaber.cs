using Terraria;
using Terraria.ModLoader;
using OSTARsSWORDS.Content.Projectiles;

namespace OSTARsSWORDS.Content.Items.Swords;

public class DoubleBladedLightsaber : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.damage = 65;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
		Item.width = 67;
		Item.height = 67;
		Item.scale = 2f;
		Item.useTime = 10;
		Item.useAnimation = 10;
		Item.channel = true;
		Item.useStyle = 100;
		Item.knockBack = 8f;
		Item.value = Item.sellPrice(0, 4, 0, 0);
		Item.rare = 7;
		Item.shoot = ModContent.ProjectileType<DoubleBladedLightsaberProjectile>();
		Item.noUseGraphic = true;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(3769, 1);
		recipe.AddIngredient(3768, 1);
		recipe.AddIngredient(3767, 1);
		recipe.AddIngredient(3766, 1);
		recipe.AddIngredient(3764, 1);
		recipe.AddIngredient(3765, 1);
		recipe.AddIngredient(547, 12);
		recipe.AddIngredient(549, 12);
		recipe.AddIngredient(548, 12);
		recipe.AddIngredient(Mod, "UpgradeMatter", 1);
		recipe.AddIngredient(502, 50);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}
}
