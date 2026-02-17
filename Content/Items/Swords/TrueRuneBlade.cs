using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class TrueRuneBlade : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 68;
		Item.height = 68;
		Item.scale = 1.2f;
		Item.rare = ItemRarityID.Red;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 15;
		Item.useAnimation = 15;
		Item.damage = 60;
		Item.knockBack = 7f;
		Item.UseSound = SoundID.Item60;
		Item.shoot = ProjectileID.GoldenShowerFriendly;
		Item.shootSpeed = 20f;
		Item.value = Item.sellPrice(0, 6, 0, 0);
		Item.expert = true;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "OrangeRuneSword", 1);
		recipe.AddIngredient(Mod, "BlueRuneBlade", 1);
		recipe.AddIngredient(Mod, "GreenRuneBlade", 1);
		recipe.AddIngredient(Mod, "YellowRuneBlade", 1);
		recipe.AddIngredient(Mod, "PurpleRuneBlade", 1);
		recipe.AddIngredient(Mod, "RedRuneBlade", 1);
		recipe.AddIngredient(Mod, "Orichalcon", 1);
		recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
		recipe.AddTile(TileID.CrystalBall);
		recipe.Register();
	}

	public override void MeleeEffects(Player player, Rectangle hitbox)
	{
		if (Main.rand.Next(2) == 0)
		{
			int dust = Dust.NewDust(new Vector2((float)hitbox.X, (float)hitbox.Y), hitbox.Width, hitbox.Height, DustID.TreasureSparkle, 0f, 0f, 100, default(Color), 2f);
			Main.dust[dust].noGravity = true;
			Main.dust[dust].velocity.X -= (float)player.direction * 0f;
			Main.dust[dust].velocity.Y -= 0f;
		}
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, ProjectileID.IceBolt, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, ProjectileID.BallofFire, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, ProjectileID.ShadowFlameKnife, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, ProjectileID.CursedFlameFriendly, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		return true;
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.Ichor, 360, false);
		target.AddBuff(BuffID.Frostburn, 360, false);
		target.AddBuff(BuffID.OnFire, 360, false);
		target.AddBuff(BuffID.CursedInferno, 360, false);
		int healingAmt = damageDone / 15;
		player.statLife += healingAmt;
		player.HealEffect(healingAmt, true);
	}
}
