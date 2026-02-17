using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class StarDestroyer : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 60;
		Item.height = 60;
		Item.scale = 1.4f;
		Item.rare = ItemRarityID.Red;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 10;
		Item.useAnimation = 10;
		Item.damage = 100;
		Item.knockBack = 4.5f;
		Item.UseSound = SoundID.Item88;
		Item.shoot = ProjectileID.LunarFlare;
		Item.shootSpeed = 30f;
		Item.value = 750000;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		int numberProjectiles = 6 + Main.rand.Next(6);
		Vector2 vector2_1 = default(Vector2);
		for (int index = 0; index < numberProjectiles; index++)
		{
			vector2_1.X = (float)((double)player.position.X + (double)player.width * 0.5 + (double)(Main.rand.Next(100) * -player.direction) + ((double)((float)Main.mouseX + Main.screenPosition.X) - (double)player.position.X));
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
		recipe.AddIngredient(ItemID.LunarFlareBook, 1);
		recipe.AddIngredient(ItemID.LunarBar, 10);
		recipe.AddIngredient(Mod, "Orichalcon", 2);
		recipe.AddIngredient(ItemID.FragmentSolar, 5);
		recipe.AddIngredient(ItemID.FragmentVortex, 5);
		recipe.AddIngredient(ItemID.FragmentNebula, 5);
		recipe.AddIngredient(ItemID.FragmentStardust, 5);
		recipe.AddIngredient(Mod, "UpgradeMatter", 1);
		recipe.AddIngredient(Mod, "LunarOrb", 1);
		recipe.AddTile(TileID.LunarCraftingStation);
		recipe.Register();
	}
}
