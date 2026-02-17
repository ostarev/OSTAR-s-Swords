using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Projectiles;

public class FlareCore : ModProjectile
{
	public override void SetDefaults()
	{
		Projectile.width = 25;
		Projectile.height = 50;
		Projectile.scale = 1f;
		Projectile.aiStyle = ProjAIStyleID.Arrow;
		Projectile.friendly = true;
		Projectile.hostile = false;
		Projectile.DamageType = DamageClass.Ranged;
		Projectile.penetrate = -1;
		Projectile.ignoreWater = true;
		Projectile.tileCollide = false;
		AIType = ProjectileID.WoodenArrowFriendly;
	}

	public override void PostAI()
	{
		if (Main.rand.Next(1) == 0)
		{
			Dust obj = Dust.NewDustDirect(Projectile.position, Projectile.width, Projectile.height, DustID.LifeDrain, 0f, 0f, 0, default, 1f);
			obj.noGravity = true;
			obj.scale = 1f;
		}
	}

	public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
	{
		Player owner = Main.player[Projectile.owner];
		switch (Main.rand.Next(2))
		{
		case 0:
			owner.AddBuff(BuffID.OnFire, 700, false, false);
			break;
		case 1:
			owner.statLife += 10;
			owner.HealEffect(10, true);
			break;
		}
	}
}
