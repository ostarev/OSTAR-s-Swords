using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class GrandPiano : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 64;
		Item.height = 64;
		Item.scale = 2.5f;
		Item.rare = ItemRarityID.Orange;
		Item.crit = 10;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 20;
		Item.useAnimation = 20;
		Item.damage = 100;
		Item.knockBack = 8f;
		Item.UseSound = new SoundStyle("UniverseOfSwordsModOld/Sounds/Item/GrandPiano", (SoundType)0);
		Item.shoot = ProjectileID.WoodenArrowFriendly;
		Item.shootSpeed = 20f;
		Item.value = Item.sellPrice(0, 40, 0, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "PianoSword1", 1);
		recipe.AddIngredient(Mod, "PianoSword2", 1);
		recipe.AddIngredient(Mod, "PianoSword3", 1);
		recipe.AddIngredient(Mod, "PianoSword4", 1);
		recipe.AddTile(TileID.Autohammer);
		recipe.Register();
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X + 1f, velocity.Y + 1f, ProjectileID.CrystalBullet, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X - 1f, velocity.Y - 1f, ProjectileID.VampireKnife, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X + 2f, velocity.Y + 2f, ProjectileID.HeatRay, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X - 2f, velocity.Y - 2f, ProjectileID.BulletHighVelocity, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, ProjectileID.FrostburnArrow, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X + 3f, velocity.Y + 3f, ProjectileID.FireArrow, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X - 3f, velocity.Y - 3f, ProjectileID.FlaironBubble, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X + 4f, velocity.Y + 4f, ProjectileID.CursedArrow, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X - 4f, velocity.Y - 4f, ProjectileID.IchorArrow, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X + 5f, velocity.Y + 5f, ProjectileID.Stake, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X - 5f, velocity.Y - 5f, ProjectileID.JavelinFriendly, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X + 6f, velocity.Y + 6f, ProjectileID.JackOLantern, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X - 6f, velocity.Y - 6f, ProjectileID.Mushroom, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X + 7f, velocity.Y + 7f, ProjectileID.LostSoulFriendly, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X - 7f, velocity.Y - 7f, ProjectileID.ShadowBeamFriendly, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X + 8f, velocity.Y + 8f, ProjectileID.InfernoFriendlyBolt, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X - 8f, velocity.Y - 8f, ProjectileID.HellfireArrow, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X + 9f, velocity.Y + 9f, ProjectileID.MeteorShot, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X - 9f, velocity.Y - 9f, ProjectileID.Bone, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X + 10f, velocity.Y + 10f, ProjectileID.FallingStar, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X - 10f, velocity.Y - 10f, ProjectileID.HolyArrow, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		return true;
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.Poisoned, 360, false);
		target.AddBuff(BuffID.Electrified, 360, false);
		target.AddBuff(BuffID.Bleeding, 360, false);
		target.AddBuff(BuffID.Midas, 360, false);
		target.AddBuff(BuffID.ShadowFlame, 360, false);
		target.AddBuff(BuffID.Frostburn, 360, false);
		target.AddBuff(BuffID.Slimed, 360, false);
		target.AddBuff(BuffID.Venom, 360, false);
	}
}
