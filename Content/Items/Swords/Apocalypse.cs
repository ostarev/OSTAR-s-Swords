using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class Apocalypse : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 64;
		Item.height = 68;
		Item.scale = 1.3f;
		Item.rare = ItemRarityID.Red;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 15;
		Item.useAnimation = 15;
		Item.damage = 150;
		Item.knockBack = 12f;
		Item.UseSound = SoundID.Item116;
		Item.shoot = ProjectileID.ApprenticeStaffT3Shot;
		Item.shootSpeed = 10f;
		Item.value = Item.sellPrice(0, 30, 0, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void MeleeEffects(Player player, Rectangle hitbox)
	{
		if (Main.rand.Next(2) == 0)
		{
			int dust = Dust.NewDust(new Vector2((float)hitbox.X, (float)hitbox.Y), hitbox.Width, hitbox.Height, DustID.InfernoFork, 0f, 0f, 100, default(Color), 2f);
			Main.dust[dust].noGravity = true;
		}
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		float spread = 0.783f;
		float baseSpeed = (float)Math.Sqrt(velocity.X * velocity.X + velocity.Y * velocity.Y);
		double startAngle = Math.Atan2(velocity.X, velocity.Y) - (double)(spread / 2f);
		double deltaAngle = spread / 4f;
		for (int i = 0; i < 5; i++)
		{
			double offsetAngle = startAngle + deltaAngle * (double)i;
			Projectile.NewProjectile(source, position.X, position.Y, baseSpeed * (float)Math.Sin(offsetAngle), baseSpeed * (float)Math.Cos(offsetAngle), Item.shoot, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		}
		return false;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.ApprenticeStaffT3, 1);
		recipe.AddIngredient(ItemID.HellstoneBar, 20);
		recipe.AddIngredient(ItemID.MeteoriteBar, 20);
		recipe.AddIngredient(Mod, "MartianSaucerCore", 1);
		recipe.AddIngredient(Mod, "SwordShard", 3);
		recipe.AddIngredient(Mod, "SwordMatter", 500);
		recipe.AddTile(TileID.LunarCraftingStation);
		recipe.Register();
	}
}
