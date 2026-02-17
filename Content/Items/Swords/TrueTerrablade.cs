using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using OSTARsSWORDS.Content.Projectiles;

namespace OSTARsSWORDS.Content.Items.Swords;

public class TrueTerrablade : ModItem
{
	public override void SetDefaults()
	{
		Item.damage = 125;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
		Item.width = 108;
		Item.height = 108;
		Item.useTime = 15;
		Item.useAnimation = 15;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.knockBack = 10f;
		Item.value = Item.sellPrice(0, 25, 0, 0);
		Item.shoot = ModContent.ProjectileType<TrueTerrabladeProjectile>();
		Item.shootSpeed = 30f;
		Item.rare = ItemRarityID.Purple;
		Item.scale = 1f;
		Item.UseSound = SoundID.Item60;
		Item.autoReuse = true;
		Item.useTurn = true;
	}

	public override void MeleeEffects(Player player, Rectangle hitbox)
	{
		if (Main.rand.Next(1) == 0)
		{
			int dust = Dust.NewDust(new Vector2((float)hitbox.X, (float)hitbox.Y), hitbox.Width, hitbox.Height, DustID.Terra, 0f, 0f, 100, default(Color), 2f);
			Main.dust[dust].noGravity = true;
		}
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.TerraBlade, 3);
		recipe.AddIngredient(Mod, "TheNightmareAmalgamation", 1);
		recipe.AddTile(TileID.LunarCraftingStation);
		recipe.Register();
	}
}
