using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class GlacialCracker : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 81;
		Item.height = 81;
		Item.scale = 2f;
		Item.rare = ItemRarityID.Red;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 23;
		Item.useAnimation = 23;
		Item.damage = 180;
		Item.knockBack = 10f;
		Item.UseSound = SoundID.Item28;
		Item.shoot = ProjectileID.NorthPoleSpear;
		Item.shootSpeed = 70f;
		Item.value = Item.sellPrice(0, 50, 0, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.IceBlade, 1);
		recipe.AddIngredient(ItemID.Amarok, 1);
		recipe.AddIngredient(ItemID.Frostbrand, 2);
		recipe.AddIngredient(ItemID.NorthPole, 1);
		recipe.AddIngredient(ItemID.FrostCore, 10);
		recipe.AddIngredient(ItemID.IceFeather, 2);
		recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
		recipe.AddIngredient(ItemID.IceBlock, 999);
		recipe.AddTile(TileID.LunarCraftingStation);
		recipe.Register();
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		float numberProjectiles = 3 + Main.rand.Next(4);
		float rotation = MathHelper.ToRadians(10f);
		position += Vector2.Normalize(new Vector2(velocity.X, velocity.Y)) * 5f;
		for (int i = 0; (float)i < numberProjectiles; i++)
		{
			Vector2 perturbedSpeed = Utils.RotatedBy(new Vector2(velocity.X, velocity.Y), (double)MathHelper.Lerp(0f - rotation, rotation, (float)i / (numberProjectiles - 1f)), default(Vector2)) * 0.2f;
			Projectile.NewProjectile(source, position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		}
		return false;
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.Frostburn, 360, false);
	}
}
