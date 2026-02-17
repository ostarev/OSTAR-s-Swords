using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using OSTARsSWORDS.Content.Projectiles;

namespace OSTARsSWORDS.Content.Items.Swords;

public class Saphira : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 56;
		Item.height = 56;
		Item.scale = 1.3f;
		Item.rare = 9;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 10;
		Item.useAnimation = 10;
		Item.damage = 60;
		Item.knockBack = 7f;
		Item.UseSound = SoundID.Item46;
		Item.shoot = ModContent.ProjectileType<SaphiraProj>();
		Item.shootSpeed = 10f;
		Item.value = Item.sellPrice(0, 10, 0, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		int numberProjectiles = 4 + Main.rand.Next(4);
		Vector2 vector2_1 = default(Vector2);
		for (int index = 0; index < numberProjectiles; index++)
		{
			vector2_1.X = (float)((double)player.position.X + (double)player.width * 0.5 + (double)(Main.rand.Next(100) * -player.direction) + (double)((float)Main.mouseX + Main.screenPosition.X - player.position.X));
			vector2_1.Y = (float)((double)player.position.Y + (double)player.height * 0.5 - 600.0);
			vector2_1.X = (float)(((double)vector2_1.X + (double)player.Center.X) / 2.0) + (float)Main.rand.Next(-100, 100);
			vector2_1.Y -= 100 * index;
			float num12 = (float)Main.mouseX + Main.screenPosition.X - vector2_1.X;
			float num13 = (float)Main.mouseY + Main.screenPosition.Y - vector2_1.Y;
			if ((double)num13 < 0.0)
			{
				num13 *= -1f;
			}
			if ((double)num13 < 20.0)
			{
				num13 = 20f;
			}
			float num14 = (float)Math.Sqrt((double)num12 * (double)num12 + (double)num13 * (double)num13);
			float num15 = Item.shootSpeed / num14;
			float num16 = num12 * num15;
			float num17 = num13 * num15;
			float SpeedX = num16 + (float)Main.rand.Next(-12, 10) * 0.16f;
			float SpeedY = num17 + (float)Main.rand.Next(-12, 10) * 0.16f;
			Projectile.NewProjectile(source, vector2_1.X, vector2_1.Y, SpeedX, SpeedY, type, damage, knockback, Main.myPlayer, 0f, (float)Main.rand.Next(5), 0f);
		}
		return false;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(177, 25);
		recipe.AddIngredient(1729, 400);
		recipe.AddIngredient(2971, 1);
		recipe.AddIngredient(2994, 1);
		recipe.AddIngredient(1931, 1);
		recipe.AddIngredient(Mod, "BlizzardRage", 1);
		recipe.AddIngredient(Mod, "Orichalcon", 2);
		recipe.AddIngredient(Mod, "SwordMatter", 300);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}
}
