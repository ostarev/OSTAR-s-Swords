using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class Crystallus : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 40;
		Item.height = 46;
		Item.scale = 1f;
		Item.rare = ItemRarityID.Blue;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 25;
		Item.useAnimation = 25;
		Item.damage = 14;
		Item.knockBack = 3f;
		Item.shootSpeed = 40f;
		Item.UseSound = SoundID.Item1;
		Item.value = Item.sellPrice(0, 0, 60, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void MeleeEffects(Player player, Rectangle hitbox)
	{
		if (Main.rand.Next(2) == 0)
		{
			int dust = Dust.NewDust(new Vector2((float)hitbox.X, (float)hitbox.Y), hitbox.Width, hitbox.Height, DustID.PurificationPowder, 0f, 0f, 100, default(Color), 2f);
			Main.dust[dust].noGravity = true;
		}
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.ManaCrystal, 5);
		recipe.AddIngredient(ItemID.FallenStar, 3);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
	}
}
