using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class TrueHorrormageddon : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 35;
		Item.height = 35;
		Item.scale = 2.7f;
		Item.rare = ItemRarityID.Red;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 15;
		Item.useAnimation = 15;
		Item.damage = 600;
		Item.knockBack = 8f;
		Item.UseSound = SoundID.Item71;
		Item.shoot = ProjectileID.DeathSickle;
		Item.shootSpeed = 20f;
		Item.value = 10000000;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "Horrormageddon", 1);
		recipe.AddIngredient(Mod, "PowerOfTheGalactic", 1);
		recipe.AddIngredient(Mod, "GnomBlade", 1);
		recipe.AddIngredient(ItemID.BrokenHeroSword, 10);
		recipe.AddIngredient(Mod, "UpgradeMatter", 25);
		recipe.AddIngredient(Mod, "LunarOrb", 3);
		recipe.AddIngredient(ItemID.LuminiteBar, 100);
		recipe.AddTile(TileID.DemonAltar);
		recipe.Register();
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, ProjectileID.Meowmere, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, ProjectileID.InfernoFriendlyBlast, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, ProjectileID.VortexBeaterRocket, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, ProjectileID.StarWrath, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y + 2f, velocity.X, velocity.Y + 2f, ProjectileID.Meowmere, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y + 2f, velocity.X, velocity.Y + 2f, ProjectileID.DeathSickle, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y + 2f, velocity.X, velocity.Y + 2f, ProjectileID.InfernoFriendlyBlast, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y + 2f, velocity.X, velocity.Y + 2f, ProjectileID.VortexBeaterRocket, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y + 2f, velocity.X, velocity.Y + 2f, ProjectileID.StarWrath, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y - 2f, velocity.X, velocity.Y - 2f, ProjectileID.Meowmere, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y - 2f, velocity.X, velocity.Y - 2f, ProjectileID.DeathSickle, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y - 2f, velocity.X, velocity.Y - 2f, ProjectileID.InfernoFriendlyBlast, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y - 2f, velocity.X, velocity.Y - 2f, ProjectileID.VortexBeaterRocket, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y - 2f, velocity.X, velocity.Y - 2f, ProjectileID.StarWrath, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		return true;
	}
}
