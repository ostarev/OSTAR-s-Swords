using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class AncientKatana : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 64;
		Item.height = 68;
		Item.rare = 6;
		Item.scale = 1.4f;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 9;
		Item.useAnimation = 9;
		Item.damage = 70;
		Item.knockBack = 5f;
		Item.UseSound = SoundID.Item1;
		Item.value = 600000;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void MeleeEffects(Player player, Rectangle hitbox)
	{
		if (Main.rand.Next(3) == 0)
		{
			int dust = Dust.NewDust(new Vector2((float)hitbox.X, (float)hitbox.Y), hitbox.Width, hitbox.Height, 264, 0f, 0f, 100, default(Color), 2f);
			Main.dust[dust].noGravity = true;
		}
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "SwordMatter", 250);
		recipe.AddIngredient(Mod, "Orichalcon", 1);
		recipe.AddIngredient(547, 15);
		recipe.AddIngredient(548, 10);
		recipe.AddIngredient(520, 10);
		recipe.AddIngredient(1006, 20);
		recipe.AddIngredient(Mod, "UpgradeMatter", 1);
		recipe.AddIngredient(2273, 1);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}
}
