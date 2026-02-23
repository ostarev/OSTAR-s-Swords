using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class SuperInflation : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 35;
		Item.height = 35;
		Item.scale = 3f;
		Item.rare = ItemRarityID.Red;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.knockBack = 10f;
		Item.useTime = 12;
		Item.useAnimation = 12;
		Item.damage = 240;
		Item.shoot = ProjectileID.GoldCoin;
		Item.shootSpeed = 40f;
		Item.UseSound = SoundID.Item1;
		Item.value = 999999;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "Inflation", 1);
		recipe.AddIngredient(Mod, "CopperCoinSword", 1);
		recipe.AddIngredient(Mod, "SilverCoinSword", 1);
		recipe.AddIngredient(Mod, "GoldCoinSword", 1);
		recipe.AddIngredient(Mod, "UpgradeMatter", 2);
		recipe.AddIngredient(ItemID.LunarOre, 1);
		recipe.AddTile(TileID.LunarCraftingStation);
		recipe.Register();
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		float numberProjectiles = 10 + Main.rand.Next(10);
		float rotation = MathHelper.ToRadians(10f);
		position += Vector2.Normalize(new Vector2(velocity.X, velocity.Y)) * 10f;
		for (int i = 0; (float)i < numberProjectiles; i++)
		{
			Vector2 perturbedSpeed = Utils.RotatedBy(new Vector2(velocity.X, velocity.Y), (double)MathHelper.Lerp(0f - rotation, rotation, (float)i / (numberProjectiles - 1f)), default(Vector2)) * 0.2f;
			Projectile.NewProjectile(source, position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		}
		return false;
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.Midas, 360, false);
	}
}
