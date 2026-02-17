using Terraria;
using Terraria.ModLoader;
using OSTARsSWORDS.Content.Projectiles;
using Terraria.ID;

namespace OSTARsSWORDS.Content.Items.Swords;

public class DoubleBladedLightsaber : ModItem
{
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
		Item.rare = ItemRarityID.Lime;
		Item.shoot = ModContent.ProjectileType<DoubleBladedLightsaberProjectile>();
		Item.noUseGraphic = true;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.YellowPhasesaber, 1);
		recipe.AddIngredient(ItemID.WhitePhasesaber, 1);
		recipe.AddIngredient(ItemID.PurplePhasesaber, 1);
		recipe.AddIngredient(ItemID.GreenPhasesaber, 1);
		recipe.AddIngredient(ItemID.BluePhasesaber, 1);
		recipe.AddIngredient(ItemID.RedPhasesaber, 1);
		recipe.AddIngredient(ItemID.SoulofFright, 12);
		recipe.AddIngredient(ItemID.SoulofSight, 12);
		recipe.AddIngredient(ItemID.SoulofMight, 12);
		recipe.AddIngredient(Mod, "UpgradeMatter", 1);
		recipe.AddIngredient(ItemID.CrystalShard, 50);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}
}
