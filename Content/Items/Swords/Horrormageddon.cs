using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class Horrormageddon : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 35;
		Item.height = 35;
		Item.scale = 2.4f;
		Item.rare = 10;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 15;
		Item.useAnimation = 15;
		Item.damage = 360;
		Item.knockBack = 4f;
		Item.UseSound = SoundID.Item71;
		Item.shoot = 274;
		Item.shootSpeed = 10f;
		Item.value = 666666;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "Doomsday", 1);
		recipe.AddIngredient(Mod, "Apocalypse", 1);
		recipe.AddIngredient(3063, 1);
		recipe.AddIngredient(1826, 1);
		recipe.AddIngredient(3065, 1);
		recipe.AddIngredient(Mod, "Machine", 1);
		recipe.AddIngredient(Mod, "InnosWrath", 1);
		recipe.AddIngredient(Mod, "BeliarClaw", 1);
		recipe.AddIngredient(1525, 1);
		recipe.AddIngredient(Mod, "UpgradeMatter", 10);
		recipe.AddIngredient(Mod, "LunarOrb", 1);
		recipe.AddTile(TileID.AncientManipulator);
		recipe.Register();
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, 502, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, 296, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, 503, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, 616, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		return true;
	}
}
