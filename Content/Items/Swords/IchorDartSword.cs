using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class IchorDartSword : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 35;
		Item.height = 35;
		Item.scale = 2f;
		Item.rare = 6;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 20;
		Item.useAnimation = 20;
		Item.damage = 59;
		Item.knockBack = 6f;
		Item.UseSound = SoundID.Item99;
		Item.shoot = 479;
		Item.shootSpeed = 20f;
		Item.value = 311200;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "SwordMatter", 125);
		recipe.AddIngredient(Mod, "UpgradeMatter", 1);
		recipe.AddIngredient(3011, 999);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}
}
