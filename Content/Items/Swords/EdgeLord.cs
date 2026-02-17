using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class EdgeLord : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 35;
		Item.height = 35;
		Item.scale = 1.6f;
		Item.rare = ItemRarityID.Red;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 12;
		Item.useAnimation = 12;
		Item.damage = 222;
		Item.knockBack = 11f;
		Item.UseSound = SoundID.Item1;
		Item.shoot = ProjectileID.VampireKnife;
		Item.shootSpeed = 30f;
		Item.value = 800000;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "DraculaSword", 2);
		recipe.AddIngredient(ItemID.VampireKnives, 1);
		recipe.AddIngredient(ItemID.VampireBanner, 1);
		recipe.AddIngredient(ItemID.HellstoneBar, 80);
		recipe.AddIngredient(ItemID.LunarBar, 40);
		recipe.AddIngredient(Mod, "SwordShard", 3);
		recipe.AddIngredient(Mod, "SwordMatter", 66);
		recipe.AddIngredient(ItemID.TrueNightsEdge, 1);
		recipe.AddTile(TileID.LunarCraftingStation);
		recipe.Register();
		Recipe recipe2 = CreateRecipe();
		recipe2.AddIngredient(Mod, "DraculaSword", 2);
		recipe2.AddIngredient(ItemID.ScourgeoftheCorruptor, 1);
		recipe2.AddIngredient(ItemID.VampireBanner, 1);
		recipe2.AddIngredient(ItemID.HellstoneBar, 80);
		recipe2.AddIngredient(ItemID.LunarBar, 40);
		recipe2.AddIngredient(Mod, "SwordShard", 3);
		recipe2.AddIngredient(Mod, "SwordMatter", 66);
		recipe2.AddIngredient(ItemID.TrueNightsEdge, 1);
		recipe2.AddTile(TileID.LunarCraftingStation);
		recipe2.Register();
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		float spread = 1.74f;
		float baseSpeed = (float)Math.Sqrt(velocity.X * velocity.X + velocity.Y * velocity.Y);
		double startAngle = Math.Atan2(velocity.X, velocity.Y) - (double)(spread / 2f);
		double deltaAngle = spread / 2f;
		for (int i = 0; i < 65; i++)
		{
			double offsetAngle = startAngle + deltaAngle * (double)i;
			Projectile.NewProjectile(source, position.X, position.Y, baseSpeed * (float)Math.Sin(offsetAngle), baseSpeed * (float)Math.Cos(offsetAngle), Item.shoot, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		}
		return false;
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.Ichor, 360, false);
	}
}
