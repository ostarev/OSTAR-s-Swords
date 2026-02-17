using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class TheMasterOfCoin : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 48;
		Item.height = 48;
		Item.scale = 1.2f;
		Item.rare = 11;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 30;
		Item.useAnimation = 30;
		Item.UseSound = SoundID.Item43;
		Item.shoot = 518;
		Item.shootSpeed = 10f;
		Item.value = Item.sellPrice(0, 0, 0, 1);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		float spread = 0.087f;
		float baseSpeed = (float)Math.Sqrt(velocity.X * velocity.X + velocity.Y * velocity.Y);
		double startAngle = Math.Atan2(velocity.X, velocity.Y) - (double)(spread / 2f);
		double deltaAngle = spread / 1f;
		for (int i = 0; i < 3; i++)
		{
			double offsetAngle = startAngle + deltaAngle * (double)i;
			Projectile.NewProjectile(source, position.X, position.Y, baseSpeed * (float)Math.Sin(offsetAngle), baseSpeed * (float)Math.Cos(offsetAngle), Item.shoot, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		}
		return false;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(855, 1);
		recipe.AddIngredient(264, 10);
		recipe.AddIngredient(13, 999);
		recipe.AddIngredient(1355, 60);
		recipe.AddIngredient(Mod, "Inflation", 1);
		recipe.AddIngredient(74, 9);
		recipe.AddIngredient(73, 99);
		recipe.AddIngredient(72, 999);
		recipe.AddIngredient(71, 999);
		recipe.AddTile(TileID.AncientManipulator);
		recipe.Register();
		Recipe recipe2 = CreateRecipe();
		recipe2.AddIngredient(855, 1);
		recipe2.AddIngredient(715, 10);
		recipe2.AddIngredient(702, 999);
		recipe2.AddIngredient(1355, 60);
		recipe2.AddIngredient(Mod, "Inflation", 1);
		recipe2.AddIngredient(74, 9);
		recipe2.AddIngredient(73, 99);
		recipe2.AddIngredient(72, 999);
		recipe2.AddIngredient(71, 999);
		recipe2.AddTile(TileID.AncientManipulator);
		recipe2.Register();
	}
}
