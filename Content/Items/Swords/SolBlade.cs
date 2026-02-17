using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using OSTARsSWORDS.Content.Projectiles;

namespace OSTARsSWORDS.Content.Items.Swords;

public class SolBlade : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 86;
		Item.height = 86;
		Item.scale = 1f;
		Item.rare = ItemRarityID.Quest;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 20;
		Item.useAnimation = 20;
		Item.damage = 80;
		Item.knockBack = 8f;
		Item.UseSound = SoundID.Item70;
		Item.shootSpeed = 40f;
		Item.shoot = ModContent.ProjectileType<Armageddon>();
		Item.value = Item.sellPrice(0, 50, 0, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void MeleeEffects(Player player, Rectangle hitbox)
	{
		if (Main.rand.Next(3) == 0)
		{
			int dust = Dust.NewDust(new Vector2((float)hitbox.X, (float)hitbox.Y), hitbox.Width, hitbox.Height, DustID.InfernoFork, 0f, 0f, 100, default(Color), 2f);
			Main.dust[dust].noGravity = true;
		}
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		int numberProjectiles = 8 + Main.rand.Next(2);
		for (int i = 0; i < numberProjectiles; i++)
		{
			Vector2 perturbedSpeed = Utils.RotatedByRandom(new Vector2(velocity.X, velocity.Y), (double)MathHelper.ToRadians(40f));
			Projectile.NewProjectile(source, position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockback, player.whoAmI, 0f, 0f, 0f);
		}
		return false;
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		IEntitySource source = Item.GetSource_OnHit((Entity)(object)target, (string)null);
		if (Main.rand.Next(3) == 0)
		{
			Projectile.NewProjectile(source, ((Entity)target).Center.X, ((Entity)target).Center.Y, 0f, 0f, ProjectileID.InfernoFriendlyBlast, damageDone, hit.Knockback, player.whoAmI, 0f, 0f, 0f);
		}
	}
}
