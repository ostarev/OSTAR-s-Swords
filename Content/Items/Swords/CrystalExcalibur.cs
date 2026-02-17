using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class CrystalExcalibur : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 84;
		Item.height = 84;
		Item.scale = 1.5f;
		Item.rare = 8;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 7;
		Item.useAnimation = 7;
		Item.damage = 150;
		Item.knockBack = 10f;
		Item.UseSound = SoundID.Item1;
		Item.value = 990000;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void MeleeEffects(Player player, Rectangle hitbox)
	{
		if (Main.rand.Next(1) == 0)
		{
			int dust = Dust.NewDust(new Vector2((float)hitbox.X, (float)hitbox.Y), hitbox.Width, hitbox.Height, 135, 0f, 0f, 100, default(Color), 2f);
			Main.dust[dust].noGravity = true;
			dust = Dust.NewDust(new Vector2((float)hitbox.X, (float)hitbox.Y), hitbox.Width, hitbox.Height, 242, 0f, 0f, 100, default(Color), 2f);
			Main.dust[dust].noGravity = true;
		}
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "OmegaExcalibur", 1);
		recipe.AddIngredient(Mod, "AlphaExcalibur", 1);
		recipe.AddIngredient(Mod, "AncientKatana", 1);
		recipe.AddIngredient(502, 20);
		recipe.AddIngredient(501, 15);
		recipe.AddIngredient(521, 10);
		recipe.AddIngredient(520, 10);
		recipe.AddIngredient(1006, 5);
		recipe.AddIngredient(527, 1);
		recipe.AddIngredient(528, 1);
		recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
		recipe.AddIngredient(Mod, "MartianSaucerCore", 1);
		recipe.AddIngredient(Mod, "Orichalcon", 1);
		recipe.AddIngredient(Mod, "SwordMatter", 150);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}
}
