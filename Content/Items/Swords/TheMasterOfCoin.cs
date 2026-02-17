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
		Item.rare = ItemRarityID.Purple;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 30;
		Item.useAnimation = 30;
		Item.UseSound = SoundID.Item43;
		Item.shoot = ProjectileID.CoinPortal;
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
		recipe.AddIngredient(ItemID.LuckyCoin, 1);
		recipe.AddIngredient(ItemID.GoldCrown, 10);
		recipe.AddIngredient(ItemID.GoldOre, 999);
		recipe.AddIngredient(ItemID.FlaskofGold, 60);
		recipe.AddIngredient(Mod, "Inflation", 1);
		recipe.AddIngredient(ItemID.PlatinumCoin, 9);
		recipe.AddIngredient(ItemID.GoldCoin, 99);
		recipe.AddIngredient(ItemID.SilverCoin, 999);
		recipe.AddIngredient(ItemID.CopperCoin, 999);
		recipe.AddTile(TileID.LunarCraftingStation);
		recipe.Register();
		Recipe recipe2 = CreateRecipe();
		recipe2.AddIngredient(ItemID.LuckyCoin, 1);
		recipe2.AddIngredient(ItemID.PlatinumCrown, 10);
		recipe2.AddIngredient(ItemID.PlatinumOre, 999);
		recipe2.AddIngredient(ItemID.FlaskofGold, 60);
		recipe2.AddIngredient(Mod, "Inflation", 1);
		recipe2.AddIngredient(ItemID.PlatinumCoin, 9);
		recipe2.AddIngredient(ItemID.GoldCoin, 99);
		recipe2.AddIngredient(ItemID.SilverCoin, 999);
		recipe2.AddIngredient(ItemID.CopperCoin, 999);
		recipe2.AddTile(TileID.LunarCraftingStation);
		recipe2.Register();
	}
}
