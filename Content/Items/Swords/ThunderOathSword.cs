using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class ThunderOathSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 32;
		Item.height = 32;
		Item.scale = 1.3f;
		Item.rare = 7;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 30;
		Item.useAnimation = 30;
		Item.damage = 40;
		Item.knockBack = 4f;
		Item.UseSound = SoundID.Item92;
		Item.shoot = 443;
		Item.shootSpeed = 10f;
		Item.value = Item.sellPrice(0, 2, 0, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
		recipe.AddIngredient(ItemID.NightsEdge, 1);
		recipe.AddIngredient(Mod, "UpgradeMatter", 2);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}
}
