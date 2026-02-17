using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class CosmoStorm : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 35;
		Item.height = 35;
		Item.scale = 1.5f;
		Item.rare = ItemRarityID.Red;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.knockBack = 1f;
		Item.useTime = 18;
		Item.useAnimation = 18;
		Item.damage = 280;
		Item.UseSound = SoundID.Item15;
		Item.shoot = ProjectileID.NebulaArcanum;
		Item.shootSpeed = 10f;
		Item.value = 650000;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.FragmentNebula, 80);
		recipe.AddIngredient(ItemID.FragmentSolar, 80);
		recipe.AddIngredient(Mod, "LunarOrb", 1);
		recipe.AddIngredient(Mod, "PowerOfTheGalactic", 1);
		recipe.AddIngredient(ItemID.LunarBar, 40);
		recipe.AddIngredient(ItemID.PortalGun, 1);
		recipe.AddIngredient(ItemID.NebulaArcanum, 1);
		recipe.AddIngredient(ItemID.TrueExcalibur, 1);
		recipe.AddIngredient(ItemID.LargeAmethyst, 4);
		recipe.AddIngredient(Mod, "UpgradeMatter", 10);
		recipe.AddTile(TileID.LunarCraftingStation);
		recipe.Register();
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		int numProjectiles = 3;
		float spread = MathHelper.ToRadians(5f); // Adjust width of spread

		for (int i = 0; i < numProjectiles; i++)
		{
			// Rotate the velocity for this projectile
			float rotation = MathHelper.Lerp(-spread, spread, i / (float)(numProjectiles - 1));
			Vector2 perturbedSpeed = velocity.RotatedBy(rotation);
			
			// Create the projectile and ensure it scales with Melee damage
			Projectile proj = Projectile.NewProjectileDirect(source, position, perturbedSpeed, type, damage, knockback, player.whoAmI);
			proj.DamageType = DamageClass.Melee;
		}

		return false; // Prevent the default 4th projectile from firing
	}
}
