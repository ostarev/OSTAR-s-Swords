using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class MagicMirrorBlade : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 60;
		Item.height = 64;
		Item.scale = 1f;
		Item.rare = ItemRarityID.Green;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 25;
		Item.useAnimation = 25;
		Item.UseSound = SoundID.Item1;
		Item.value = Item.sellPrice(0, 0, 50, 0);
		Item.autoReuse = false;
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
			Item.useTime = 90;
			Item.useAnimation = 90;
			Item.UseSound = SoundID.Item6; // Magic Mirror sound
		}
		else
		{
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.UseSound = SoundID.Item1; // Sword Swing sound
		}
		return base.CanUseItem(player);
	}

	public override void UseStyle(Player player, Rectangle heldItemFrame)
	{
		// Only run teleport logic on Right Click
		if (player.altFunctionUse == 2)
		{
			if (player.itemTime == 0)
			{
				player.itemTime = (int)((float)Item.useTime / PlayerLoader.UseTimeMultiplier(player, Item));
			}
			else if (player.itemTime == (int)((float)Item.useTime / PlayerLoader.UseTimeMultiplier(player, Item)) / 2)
			{
				// Spawn dust effects
				for (int d = 0; d < 70; d++)
				{
					Dust.NewDust(player.position, player.width, player.height, DustID.MagicMirror, player.velocity.X * 0.5f, player.velocity.Y * 0.5f, 150, default, 1.5f);
				}

				// Kill grappling hooks
				player.grappling[0] = -1;
				player.grapCount = 0;
				for (int p = 0; p < 1000; p++)
				{
					if (Main.projectile[p].active && Main.projectile[p].owner == player.whoAmI && Main.projectile[p].aiStyle == ProjAIStyleID.Hook)
					{
						Main.projectile[p].Kill();
					}
				}

				// Teleport home
				player.Spawn(PlayerSpawnContext.RecallFromItem);

				// Post-teleport dust
				for (int i = 0; i < 70; i++)
				{
					Dust.NewDust(player.position, player.width, player.height, 15, 0f, 0f, 150, default(Color), 1.5f);
				}
			}
		}
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.MagicMirror, 1);
		recipe.Register();
	}
}
