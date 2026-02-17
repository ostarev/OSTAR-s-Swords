using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ModLoader;
using OSTARsSWORDS.Content.Projectiles;
using Terraria.ID;

namespace OSTARsSWORDS.Content.Items.Swords;

public class Caladbolg : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 535;
		Item.height = 534;
		Item.scale = 1f;
		Item.rare = ItemRarityID.Lime;
		Item.crit = 96;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 25;
		Item.useAnimation = 25;
		Item.damage = 666666;
		Item.knockBack = 50f;
		Item.UseSound = new SoundStyle("UniverseOfSwordsModOld/Sounds/Item/Ghost", (SoundType)0);
		Item.shoot = ModContent.ProjectileType<GreenSaw>();
		Item.shootSpeed = 30f;
		Item.value = Item.sellPrice(1000000, 0, 0, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		float spread = 0.5f;
		float baseSpeed = (float)Math.Sqrt(velocity.X * velocity.X + velocity.Y * velocity.Y);
		double startAngle = Math.Atan2(velocity.X, velocity.Y) - (double)(spread / 2f);
		double deltaAngle = spread / 2f;
		for (int i = 0; i < 3; i++)
		{
			double offsetAngle = startAngle + deltaAngle * (double)i;
			Projectile.NewProjectile(source, position.X, position.Y, baseSpeed * (float)Math.Sin(offsetAngle), baseSpeed * (float)Math.Cos(offsetAngle), Item.shoot, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		}
		return false;
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.Poisoned, 1000, false);
		target.AddBuff(BuffID.CursedInferno, 1000, false);
	}
}
