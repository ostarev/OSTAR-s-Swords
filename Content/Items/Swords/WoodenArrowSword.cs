using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class WoodenArrowSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 38;
		Item.height = 38;
		Item.scale = 1.1f;
		Item.rare = 0;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 30;
		Item.useAnimation = 30;
		Item.damage = 10;
		Item.knockBack = 2f;
		Item.UseSound = SoundID.Item5;
		Item.shoot = 1;
		Item.shootSpeed = 10f;
		Item.value = 3500;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(40, 999);
		recipe.AddIngredient(Mod, "SwordMatter", 80);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
	}
}
