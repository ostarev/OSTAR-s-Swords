using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
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
		Item.rare = ItemRarityID.Yellow;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 30;
		Item.useAnimation = 30;
		Item.damage = 88;
		Item.knockBack = 3f;
		Item.UseSound = new SoundStyle("UniverseOfSwordsModOld/Sounds/Item/PianoYellow", (SoundType)0);
		Item.shoot = ProjectileID.HolyArrow;
		Item.shootSpeed = 17f;
		Item.value = Item.sellPrice(0, 12, 0, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.PearlwoodPiano, 1);
		recipe.AddIngredient(ItemID.MartianPiano, 1);
		recipe.AddIngredient(ItemID.CrystalPiano, 1);
		recipe.AddIngredient(ItemID.SpookyPiano, 1);
		recipe.AddIngredient(ItemID.FleshPiano, 1);
		recipe.AddIngredient(ItemID.LihzahrdPiano, 1);
		recipe.AddIngredient(ItemID.SteampunkPiano, 1);
		recipe.AddIngredient(ItemID.GoldenPiano, 1);
		recipe.AddTile(TileID.Sawmill);
		recipe.Register();
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, ProjectileID.CrystalBullet, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, ProjectileID.VampireKnife, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, ProjectileID.HeatRay, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, ProjectileID.BulletHighVelocity, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		return true;
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.Electrified, 360, false);
		target.AddBuff(BuffID.Bleeding, 360, false);
		target.AddBuff(BuffID.Midas, 360, false);
	}
}
