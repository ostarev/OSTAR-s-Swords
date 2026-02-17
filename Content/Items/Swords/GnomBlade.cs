using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class GnomBlade : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 64;
		Item.height = 64;
		Item.scale = 1.2f;
		Item.rare = ItemRarityID.Red;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 9;
		Item.useAnimation = 9;
		Item.damage = 375;
		Item.knockBack = 15f;
		Item.shoot = ProjectileID.DD2PhoenixBowShot;
		Item.shootSpeed = 40f;
		Item.UseSound = SoundID.Item1;
		Item.value = Item.sellPrice(1, 0, 0, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.FragmentSolar, 10);
		recipe.AddIngredient(ItemID.FragmentVortex, 10);
		recipe.AddIngredient(ItemID.FragmentNebula, 10);
		recipe.AddIngredient(ItemID.FragmentStardust, 10);
		recipe.AddIngredient(ItemID.LuminiteBar, 14);
		recipe.AddIngredient(Mod, "Dragrael", 1);
		recipe.AddIngredient(Mod, "Doomsday", 1);
		recipe.AddIngredient(ItemID.TerraBlade, 1);
		recipe.AddIngredient(Mod, "LunarOrb", 1);
		recipe.AddIngredient(Mod, "Orichalcon", 3);
		recipe.AddIngredient(Mod, "SwordMatter", 200);
		recipe.AddTile(TileID.AncientManipulator);
		recipe.Register();
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, ProjectileID.TerraBeam, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, ProjectileID.NightBeam, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, ProjectileID.InfernoFriendlyBlast, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		return true;
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.Midas, 360, false);
		target.AddBuff(BuffID.Ichor, 360, false);
		target.AddBuff(BuffID.Frostburn, 360, false);
		target.AddBuff(BuffID.OnFire, 360, false);
		target.AddBuff(BuffID.Poisoned, 360, false);
		target.AddBuff(BuffID.Venom, 360, false);
		target.AddBuff(BuffID.Confused, 360, false);
		target.AddBuff(BuffID.CursedInferno, 360, false);
		target.AddBuff(BuffID.Slimed, 360, false);
	}
}
