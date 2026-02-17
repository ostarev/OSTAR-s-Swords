using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class BuzzKill : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 32;
		Item.height = 32;
		Item.scale = 1.3f;
		Item.rare = ItemRarityID.LightPurple;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 20;
		Item.useAnimation = 20;
		Item.damage = 30;
		Item.knockBack = 1f;
		Item.UseSound = SoundID.Item1;
		Item.shoot = ProjectileID.Beenade;
		Item.shootSpeed = 8f;
		Item.value = Item.sellPrice(0, 5, 0, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		float spread = 0.174f;
		float baseSpeed = (float)Math.Sqrt(velocity.X * velocity.X + velocity.Y * velocity.Y);
		double startAngle = Math.Atan2(velocity.X, velocity.Y) - (double)(spread / 2f);
		double deltaAngle = spread / 2f;
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
		recipe.AddIngredient(ItemID.BeeKeeper, 1);
		recipe.AddIngredient(ItemID.BeeGun, 1);
		recipe.AddIngredient(ItemID.Beenade, 80);
		recipe.AddIngredient(ItemID.HallowedBar, 10);
		recipe.AddIngredient(ItemID.HoneyBlock, 500);
		recipe.AddIngredient(ItemID.Hive, 500);
		recipe.AddIngredient(Mod, "TheStinger", 1);
		recipe.AddTile(TileID.HoneyDispenser);
		recipe.Register();
	}
}
