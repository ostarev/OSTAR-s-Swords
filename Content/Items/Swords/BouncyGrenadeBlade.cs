using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class BouncyGrenadeBlade : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 56;
		Item.height = 56;
		Item.scale = 1f;
		Item.rare = 4;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 28;
		Item.useAnimation = 25;
		Item.damage = 40;
		Item.knockBack = 8f;
		Item.UseSound = SoundID.Item1;
		Item.shoot = 517;
		Item.shootSpeed = 10f;
		Item.value = Item.sellPrice(0, 2, 0, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(3111, 48);
		recipe.AddIngredient(168, 99);
		recipe.AddIngredient(530, 20);
		recipe.AddIngredient(Mod, "DamascusBar", 15);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
	}
}
