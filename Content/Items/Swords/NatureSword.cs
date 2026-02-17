using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class NatureSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 72;
		Item.height = 72;
		Item.scale = 1f;
		Item.rare = ItemRarityID.Green;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 25;
		Item.useAnimation = 25;
		Item.damage = 15;
		Item.knockBack = 6f;
		Item.shoot = ProjectileID.VilethornBase;
		Item.shootSpeed = 20f;
		Item.UseSound = SoundID.Item1;
		Item.value = Item.buyPrice(0, 0, 50, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void MeleeEffects(Player player, Rectangle hitbox)
	{
		if (Main.rand.Next(3) == 0)
		{
			int dust = Dust.NewDust(new Vector2((float)hitbox.X, (float)hitbox.Y), hitbox.Width, hitbox.Height, DustID.GrassBlades, 0f, 0f, 100, default(Color), 2f);
			Main.dust[dust].noGravity = true;
		}
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.Vilethorn, 1);
		recipe.AddIngredient(ItemID.Seed, 10);
		recipe.AddIngredient(ItemID.Daybloom, 5);
		recipe.AddIngredient(ItemID.DirtBlock, 100);
		recipe.AddIngredient(Mod, "SwordMatter", 40);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
		Recipe recipe2 = CreateRecipe();
		recipe2.AddIngredient(ItemID.TheRottedFork, 1);
		recipe2.AddIngredient(ItemID.Seed, 10);
		recipe2.AddIngredient(ItemID.Daybloom, 5);
		recipe2.AddIngredient(ItemID.DirtBlock, 100);
		recipe2.AddIngredient(Mod, "SwordMatter", 40);
		recipe2.AddTile(TileID.Anvils);
		recipe2.Register();
	}
}
