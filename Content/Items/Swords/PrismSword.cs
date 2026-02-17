using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class PrismSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 35;
		Item.height = 35;
		Item.scale = 1.5f;
		Item.channel = true;
		Item.rare = 10;
		Item.useStyle = ItemUseStyleID.Shoot;
		Item.damage = 120;
		Item.UseSound = SoundID.Item67;
		Item.shoot = 633;
		Item.shootSpeed = 120f;
		Item.value = 600000;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(1524, 1);
		recipe.AddIngredient(1526, 1);
		recipe.AddIngredient(1525, 1);
		recipe.AddIngredient(1523, 1);
		recipe.AddIngredient(1522, 1);
		recipe.AddIngredient(1527, 1);
		recipe.AddIngredient(502, 50);
		recipe.AddIngredient(29, 3);
		recipe.AddIngredient(109, 3);
		recipe.AddIngredient(3571, 1);
		recipe.AddIngredient(3541, 1);
		recipe.AddIngredient(ItemID.LuminiteBar, 10);
		recipe.AddTile(TileID.CrystalBall);
		recipe.Register();
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo spawnSource, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		Projectile.NewProjectileDirect((IEntitySource)(object)spawnSource, position, velocity, 633, damage, knockback, player.whoAmI, 0f, 0f, 0f).DamageType = DamageClass.Melee;
		return false;
	}
}
