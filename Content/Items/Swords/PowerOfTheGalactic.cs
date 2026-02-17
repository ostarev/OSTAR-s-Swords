using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class PowerOfTheGalactic : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 32;
		Item.height = 32;
		Item.scale = 1.5f;
		Item.rare = ItemRarityID.Red;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 20;
		Item.useAnimation = 20;
		Item.damage = 288;
		Item.knockBack = 15f;
		Item.shoot = ProjectileID.NebulaBlaze2;
		Item.shootSpeed = 10f;
		Item.UseSound = SoundID.Item1;
		Item.value = 650500;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.FragmentSolar, 15);
		recipe.AddIngredient(ItemID.FragmentVortex, 15);
		recipe.AddIngredient(ItemID.FragmentNebula, 15);
		recipe.AddIngredient(ItemID.FragmentStardust, 15);
		recipe.AddIngredient(ItemID.LunarBar, 10);
		recipe.AddIngredient(Mod, "LunarOrb", 1);
		recipe.AddIngredient(Mod, "SwordMatter", 150);
		recipe.AddTile(TileID.LunarCraftingStation);
		recipe.Register();
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		int numProjectiles = 3;
		float spread = MathHelper.ToRadians(10f); // Adjust this value to change the width of the spread

		for (int i = 0; i < numProjectiles; i++)
		{
			// Calculate the rotation for this specific projectile
			float rotation = MathHelper.Lerp(-spread, spread, i / (float)(numProjectiles - 1));
			Vector2 perturbedSpeed = velocity.RotatedBy(rotation);
			
			// Create the projectile and ensure it deals Melee damage
			Projectile proj = Projectile.NewProjectileDirect(source, position, perturbedSpeed, type, damage, knockback, player.whoAmI);
			proj.DamageType = DamageClass.Melee;
		}

		return false; // Return false so the original projectile (from SetDefaults) doesn't fire as well
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.Ichor, 360, false);
		target.AddBuff(BuffID.OnFire, 360, false);
		target.AddBuff(BuffID.Confused, 360, false);
		target.AddBuff(BuffID.Frostburn, 360, false);
	}
}
