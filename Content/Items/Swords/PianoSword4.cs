using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class PianoSword4 : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 64;
		Item.height = 64;
		Item.scale = 2.5f;
		Item.rare = 8;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 30;
		Item.useAnimation = 30;
		Item.damage = 88;
		Item.knockBack = 3f;
		Item.UseSound = new SoundStyle("UniverseOfSwordsModOld/Sounds/Item/PianoYellow", (SoundType)0);
		Item.shoot = 91;
		Item.shootSpeed = 17f;
		Item.value = Item.sellPrice(0, 12, 0, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(643, 1);
		recipe.AddIngredient(2821, 1);
		recipe.AddIngredient(3915, 1);
		recipe.AddIngredient(2383, 1);
		recipe.AddIngredient(2246, 1);
		recipe.AddIngredient(2385, 1);
		recipe.AddIngredient(2256, 1);
		recipe.AddIngredient(2379, 1);
		recipe.AddTile(106);
		recipe.Register();
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, 89, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, 304, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, 260, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, 242, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		return true;
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(144, 360, false);
		target.AddBuff(BuffID.Bleeding, 360, false);
		target.AddBuff(72, 360, false);
	}
}
