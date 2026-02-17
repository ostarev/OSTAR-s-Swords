using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class ShadowbeamSword : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 32;
		Item.height = 32;
		Item.scale = 1.1f;
		Item.rare = 8;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 20;
		Item.useAnimation = 20;
		Item.damage = 68;
		Item.knockBack = 6f;
		Item.UseSound = SoundID.Item72;
		Item.shoot = 294;
		Item.shootSpeed = 10f;
		Item.value = 510500;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(1444, 1);
		recipe.AddIngredient(Mod, "UpgradeMatter", 1);
		recipe.AddIngredient(Mod, "SwordMatter", 130);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}
}
