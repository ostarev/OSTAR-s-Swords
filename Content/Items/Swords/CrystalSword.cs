using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class CrystalSword : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 80;
		Item.height = 80;
		Item.scale = 0.8f;
		Item.rare = ItemRarityID.LightPurple;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 20;
		Item.useAnimation = 20;
		Item.damage = 40;
		Item.knockBack = 5f;
		Item.UseSound = SoundID.Item1;
		Item.value = 100700;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.CrystalShard, 20);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}
}
