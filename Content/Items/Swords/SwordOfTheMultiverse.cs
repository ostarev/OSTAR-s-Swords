using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ModLoader;
using OSTARsSWORDS.Content.Projectiles;
using Terraria.ID;

namespace OSTARsSWORDS.Content.Items.Swords;

public class SwordOfTheMultiverse : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 555;
		Item.height = 555;
		Item.scale = 1f;
		Item.rare = ItemRarityID.Purple;
		Item.crit = 65;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.axe = 1000;
		Item.useTime = 15;
		Item.useAnimation = 15;
		Item.damage = 80085;
		Item.knockBack = 2f;
		Item.UseSound = new SoundStyle("UniverseOfSwordsModOld/Sounds/Item/SOTM", (SoundType)0);
		Item.shoot = ModContent.ProjectileType<SOTM>();
		Item.shootSpeed = 30f;
		Item.expert = true;
		Item.value = Item.sellPrice(90, 0, 0, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X + 10f, velocity.Y + 10f, ModContent.ProjectileType<SOTM>(), damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X - 10f, velocity.Y - 10f, ModContent.ProjectileType<SOTM>(), damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, ModContent.ProjectileType<SOTUProjectile1>(), damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X + 5f, velocity.Y + 5f, ModContent.ProjectileType<SOTUProjectile2>(), damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X - 5f, velocity.Y - 5f, ModContent.ProjectileType<SOTUProjectile3>(), damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X + 8f, velocity.Y + 8f, ModContent.ProjectileType<SOTUV4Projectile>(), damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X - 8f, velocity.Y - 8f, ModContent.ProjectileType<SOTUV5Projectile>(), damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X + 12f, velocity.Y + 12f, ModContent.ProjectileType<SOTUV6Projectile>(), damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X - 13f, velocity.Y - 13f, ModContent.ProjectileType<SOTU7>(), damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X + 12f, velocity.Y + 12f, ModContent.ProjectileType<SOTU8>(), damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X - 10f, velocity.Y - 10f, ModContent.ProjectileType<SOTUV9Projectile>(), damage, knockback, player.whoAmI, 0f, 0f, 0f);
		return true;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "SwordOfTheUniverse", 1);
		recipe.AddIngredient(Mod, "SwordOfTheUniverseV2", 1);
		recipe.AddIngredient(Mod, "SwordOfTheUniverseV3", 1);
		recipe.AddIngredient(Mod, "SwordOfTheUniverseV4", 1);
		recipe.AddIngredient(Mod, "SwordOfTheUniverseV5", 1);
		recipe.AddIngredient(Mod, "SwordOfTheUniverseV6", 1);
		recipe.AddIngredient(Mod, "SwordOfTheUniverseV7", 1);
		recipe.AddIngredient(Mod, "SwordOfTheUniverseV8", 1);
		recipe.AddIngredient(Mod, "SwordOfTheUniverseV9", 1);
		recipe.Register();
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(Mod.Find<ModBuff>("EmperorBlaze").Type, 1000, true);
	}
}
