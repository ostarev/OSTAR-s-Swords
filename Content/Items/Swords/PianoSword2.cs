using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class PianoSword2 : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 64;
		Item.height = 64;
		Item.scale = 2.5f;
		Item.rare = ItemRarityID.Cyan;
		Item.crit = 6;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 30;
		Item.useAnimation = 30;
		Item.damage = 44;
		Item.knockBack = 8f;
		Item.UseSound = new SoundStyle("UniverseOfSwordsModOld/Sounds/Item/PianoBlue", (SoundType)0);
		Item.shoot = ProjectileID.Mushroom;
		Item.shootSpeed = 15f;
		Item.value = 80000;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.MushroomPiano, 1);
		recipe.AddIngredient(ItemID.GranitePiano, 1);
		recipe.AddIngredient(ItemID.MarblePiano, 1);
		recipe.AddIngredient(ItemID.PumpkinPiano, 1);
		recipe.AddIngredient(ItemID.DynastyPiano, 1);
		recipe.AddIngredient(ItemID.FrozenPiano, 1);
		recipe.AddIngredient(ItemID.GlassPiano, 1);
		recipe.AddIngredient(ItemID.HoneyPiano, 1);
		recipe.AddTile(TileID.Sawmill);
		recipe.Register();
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, ProjectileID.JavelinFriendly, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, ProjectileID.JackOLantern, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		return true;
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.ShadowFlame, 360, false);
		target.AddBuff(BuffID.Frostburn, 360, false);
		target.AddBuff(BuffID.Venom, 360, false);
	}
}
