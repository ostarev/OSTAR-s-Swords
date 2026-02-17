using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class CrystalExcalibur : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 84;
		Item.height = 84;
		Item.scale = 1.5f;
		Item.rare = ItemRarityID.Yellow;
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
			int dust = Dust.NewDust(new Vector2((float)hitbox.X, (float)hitbox.Y), hitbox.Width, hitbox.Height, DustID.IceTorch, 0f, 0f, 100, default(Color), 2f);
			Main.dust[dust].noGravity = true;
			dust = Dust.NewDust(new Vector2((float)hitbox.X, (float)hitbox.Y), hitbox.Width, hitbox.Height, DustID.PinkTorch, 0f, 0f, 100, default(Color), 2f);
			Main.dust[dust].noGravity = true;
		}
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "OmegaExcalibur", 1);
		recipe.AddIngredient(Mod, "AlphaExcalibur", 1);
		recipe.AddIngredient(Mod, "AncientKatana", 1);
		recipe.AddIngredient(ItemID.CrystalShard, 20);
		recipe.AddIngredient(ItemID.PixieDust, 15);
		recipe.AddIngredient(ItemID.SoulofNight, 10);
		recipe.AddIngredient(ItemID.SoulofLight, 10);
		recipe.AddIngredient(ItemID.ChlorophyteBar, 5);
		recipe.AddIngredient(ItemID.DarkShard, 1);
		recipe.AddIngredient(ItemID.LightShard, 1);
		recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
		recipe.AddIngredient(Mod, "MartianSaucerCore", 1);
		recipe.AddIngredient(Mod, "Orichalcon", 1);
		recipe.AddIngredient(Mod, "SwordMatter", 150);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}
}
