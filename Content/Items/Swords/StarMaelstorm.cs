using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class StarMaelstorm : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 58;
		Item.height = 66;
		Item.scale = 1.2f;
		Item.rare = ItemRarityID.Purple;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 15;
		Item.useAnimation = 15;
		Item.damage = 200;
		Item.knockBack = 10f;
		Item.UseSound = SoundID.Item105;
		Item.shoot = ProjectileID.StarWrath;
		Item.shootSpeed = 20f;
		Item.value = Item.sellPrice(0, 50, 0, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override bool AltFunctionUse(Player player)
	{
		return true;
	}

	public override bool CanUseItem(Player player)
	{
		if (player.altFunctionUse == 2)
		{
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTime = 70;
			Item.useAnimation = 70;
			Item.damage = 100;
			Item.shoot = ProjectileID.DD2ApprenticeStorm;
		}
		else
		{
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.damage = 200;
			Item.shoot = ProjectileID.StarWrath;
		}
		return base.CanUseItem(player);
	}

	public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
	{
		Vector2 target = Main.MouseWorld;
		float ceilingLimit = target.Y;
		if (ceilingLimit > player.Center.Y - 200f)
		{
			ceilingLimit = player.Center.Y - 200f;
		}

		for (int i = 0; i < 15; i++)
		{
			// Calculate spawn position above the player with some horizontal offset
			Vector2 spawnPos = player.Center + new Vector2(-Main.rand.Next(0, 901) * player.direction, -600f);
			spawnPos.Y -= 100 * i;

			Vector2 heading = target - spawnPos;
			if (heading.Y < 0f)
			{
				heading.Y *= -1f; // Ensure it comes from above
			}
			if (heading.Y < 20f)
			{
				heading.Y = 20f;
			}

			heading.Normalize();
			heading *= velocity.Length();
			
			Vector2 perturbedVelocity = new Vector2(heading.X, heading.Y + Main.rand.Next(-800, 801) * 0.02f);
			
			// NewProjectile using Vector2 for position and velocity
			Projectile.NewProjectile(source, spawnPos, perturbedVelocity / 2f, type, damage * 2, knockback, player.whoAmI, 0f, ceilingLimit);
		}
		return false;
	}
}
