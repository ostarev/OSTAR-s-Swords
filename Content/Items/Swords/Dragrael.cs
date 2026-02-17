using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class Dragrael : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 58;
		Item.height = 58;
		Item.scale = 1.1f;
		Item.rare = ItemRarityID.Lime;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 15;
		Item.useAnimation = 15;
		Item.damage = 124;
		Item.knockBack = 6f;
		Item.UseSound = SoundID.Item1;
		Item.value = 780000;
		Item.shoot = ProjectileID.TerraBeam;
		Item.shootSpeed = 20f;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void MeleeEffects(Player player, Rectangle hitbox)
	{
		if (Main.rand.Next(5) == 0)
		{
			int dust = Dust.NewDust(new Vector2((float)hitbox.X, (float)hitbox.Y), hitbox.Width, hitbox.Height, DustID.GreenFairy, 0f, 0f, 100, default(Color), 2f);
			Main.dust[dust].noGravity = true;
			dust = Dust.NewDust(new Vector2((float)hitbox.X, (float)hitbox.Y), hitbox.Width, hitbox.Height, DustID.TheDestroyer, 0f, 0f, 100, default(Color), 2f);
			Main.dust[dust].noGravity = true;
			dust = Dust.NewDust(new Vector2((float)hitbox.X, (float)hitbox.Y), hitbox.Width, hitbox.Height, DustID.HallowSpray, 0f, 0f, 100, default(Color), 2f);
			Main.dust[dust].noGravity = true;
		}
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "ZarRoc", 1);
		recipe.AddIngredient(Mod, "Tamerlein", 1);
		recipe.AddIngredient(Mod, "Brisingr", 1);
		recipe.AddIngredient(ItemID.SoulofNight, 10);
		recipe.AddIngredient(ItemID.SoulofLight, 10);
		recipe.AddIngredient(ItemID.SoulofSight, 10);
		recipe.AddIngredient(ItemID.SoulofFright, 10);
		recipe.AddIngredient(ItemID.SoulofMight, 10);
		recipe.AddIngredient(ItemID.PixieDust, 25);
		recipe.AddIngredient(Mod, "SwordMatter", 150);
		recipe.AddIngredient(Mod, "Orichalcon", 1);
		recipe.AddIngredient(ItemID.TerraBlade, 1);
		recipe.AddTile(TileID.DemonAltar);
		recipe.Register();
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		float spread = 0.087f;
		float baseSpeed = (float)Math.Sqrt(velocity.X * velocity.X + velocity.Y * velocity.Y);
		double startAngle = Math.Atan2(velocity.X, velocity.Y) - (double)(spread / 2f);
		double deltaAngle = spread / 1f;
		for (int i = 0; i < 2; i++)
		{
			double offsetAngle = startAngle + deltaAngle * (double)i;
			Projectile.NewProjectile(source, position.X, position.Y, baseSpeed * (float)Math.Sin(offsetAngle), baseSpeed * (float)Math.Cos(offsetAngle), Item.shoot, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		}
		return false;
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.Midas, 360, false);
		target.AddBuff(BuffID.ShadowFlame, 360, false);
		target.AddBuff(BuffID.Confused, 360, false);
		target.AddBuff(BuffID.OnFire, 360, false);
		target.AddBuff(BuffID.Frostburn, 360, false);
	}
}
