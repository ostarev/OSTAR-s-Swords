using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class Inflation : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 64;
		Item.height = 64;
		Item.scale = 2.5f;
		Item.rare = ItemRarityID.Red;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.knockBack = 10f;
		Item.useTime = 32;
		Item.useAnimation = 62;
		Item.damage = 240;
		Item.UseSound = SoundID.Item1;
		Item.value = 999999;
		Item.autoReuse = true;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.GoldCoin, 2000);
		recipe.AddRecipeGroup("UniverseOfSwordsModOld:GoldCrates", 10);
		recipe.AddRecipeGroup("UniverseOfSwordsModOld:GoldBricks", 999);
		recipe.AddRecipeGroup("UniverseOfSwordsModOld:GoldSwords", 10);
		recipe.AddRecipeGroup("UniverseOfSwordsModOld:GoldBars", 500);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.Midas, 360, false);
	}
}
