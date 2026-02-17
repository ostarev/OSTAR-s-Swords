using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Projectiles;

public class ScarletFlareBolt : ModProjectile
{
	public override void SetDefaults()
	{
		Projectile.width = 14;
		Projectile.height = 20;
		Projectile.scale = 1f;
		Projectile.aiStyle = ProjAIStyleID.Arrow;
		Projectile.friendly = true;
		Projectile.hostile = false;
		Projectile.DamageType = DamageClass.Ranged;
		Main.projFrames[Projectile.type] = 5;
		Projectile.penetrate = 1;
		Projectile.ignoreWater = true;
		Projectile.tileCollide = true;
		AIType = ProjectileID.WoodenArrowFriendly;
	}

	public override void PostAI()
	{
		if (Main.rand.Next(1) == 0)
		{
			Dust obj = Dust.NewDustDirect(Projectile.position, Projectile.width, Projectile.height, DustID.Firework_Red, 0f, 0f, 0, default(Color), 1f);
			obj.noGravity = true;
			obj.scale = 1f;
		}
	}

	public override bool PreDraw(ref Color lightColor)
	{
		Projectile projectile = Projectile;
		projectile.frameCounter++;
		if (Projectile.frameCounter >= 6)
		{
			Projectile projectile2 = Projectile;
			projectile2.frame++;
			Projectile.frameCounter = 0;
			if (Projectile.frame > 4)
			{
				Projectile.frame = 0;
			}
		}
		return true;
	}

	public override void OnKill(int timeLeft)
	{
		for (int i = 0; i < 10; i++)
		{
			Dust.NewDust(Projectile.position + Projectile.velocity, Projectile.width, Projectile.height, DustID.Firework_Red, Projectile.oldVelocity.X * 0.6f, Projectile.oldVelocity.Y * 0.1f, 0, default(Color), 1f);
		}
		SoundEngine.PlaySound(SoundID.Dig, Projectile.position);
	}

	public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.OnFire, 400, false);
	}
}
