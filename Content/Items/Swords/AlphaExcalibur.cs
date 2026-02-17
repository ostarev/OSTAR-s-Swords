using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class AlphaExcalibur : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 58;
		Item.height = 58;
		Item.scale = 1f;
		Item.rare = 7;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 10;
		Item.useAnimation = 10;
		Item.damage = 77;
		Item.knockBack = 7f;
		Item.UseSound = SoundID.Item1;
		Item.value = 680000;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void MeleeEffects(Player player, Rectangle hitbox)
	{
		if (Main.rand.Next(2) == 0)
		{
			int dust = Dust.NewDust(new Vector2((float)hitbox.X, (float)hitbox.Y), hitbox.Width, hitbox.Height, 242, 0f, 0f, 100, default(Color), 2f);
			Main.dust[dust].noGravity = true;
			Main.dust[dust].velocity.X += (float)player.direction * 2f;
			Main.dust[dust].velocity.Y += 0.2f;
		}
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.Excalibur, 1);
		recipe.AddIngredient(547, 10);
		recipe.AddIngredient(548, 10);
		recipe.AddIngredient(549, 10);
		recipe.AddIngredient(1225, 10);
		recipe.AddIngredient(527, 1);
		recipe.AddIngredient(Mod, "Orichalcon", 1);
		recipe.AddIngredient(Mod, "UpgradeMatter", 1);
		recipe.AddIngredient(Mod, "SwordMatter", 150);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}
}
