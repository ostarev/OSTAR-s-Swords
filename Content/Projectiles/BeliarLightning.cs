using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Projectiles;

internal class BeliarLightning : ModProjectile
{
	public override void SetDefaults()
	{
		Projectile.width = 50;
		Projectile.height = 50;
		Projectile.scale = 1.5f;
		Projectile.friendly = true;
		Projectile.penetrate = 1;
		Main.projFrames[Projectile.type] = 5;
		AIType = ProjectileID.WoodenArrowFriendly;
		Projectile.DamageType = DamageClass.Melee;
		Projectile.tileCollide = false;
		Projectile.ignoreWater = true;
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
}
