using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class UltraMachine : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 132;
		Item.height = 132;
		Item.scale = 1.4f;
		Item.rare = 10;
		Item.crit = 6;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 15;
		Item.useAnimation = 15;
		Item.damage = 120;
		Item.knockBack = 10f;
		Item.UseSound = SoundID.Item62;
		Item.shoot = 616;
		Item.shootSpeed = 30f;
		Item.value = Item.sellPrice(1, 0, 0, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "Machine", 1);
		recipe.AddIngredient(Mod, "SwordMatter", 1000);
		recipe.AddIngredient(Mod, "DamascusBar", 20);
		recipe.AddIngredient(1367, 1);
		recipe.AddIngredient(1366, 1);
		recipe.AddIngredient(1368, 1);
		recipe.AddIngredient(1369, 1);
		recipe.AddIngredient(3261, 20);
		recipe.AddIngredient(Mod, "PrimeSword", 1);
		recipe.AddIngredient(Mod, "DestroyerSword", 1);
		recipe.AddIngredient(Mod, "TwinsSword", 1);
		recipe.AddIngredient(Mod, "MartianSaucerCore", 1);
		recipe.AddIngredient(1552, 10);
		recipe.AddIngredient(1293, 5);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, 440, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, 134, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y + 2f, velocity.X, velocity.Y + 2f, 134, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y + 2f, velocity.X, velocity.Y + 2f, 440, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y + 2f, velocity.X, velocity.Y + 2f, 616, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y - 2f, velocity.X, velocity.Y - 2f, 134, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y - 2f, velocity.X, velocity.Y - 2f, 440, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y - 2f, velocity.X, velocity.Y - 2f, 616, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		return true;
	}
}
