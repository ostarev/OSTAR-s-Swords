using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class StoneSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 35;
		Item.height = 35;
		Item.scale = 0.8f;
		Item.rare = ItemRarityID.Blue;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 30;
		Item.useAnimation = 30;
		Item.damage = 7;
		Item.knockBack = 2f;
		Item.UseSound = SoundID.Item1;
		Item.value = 100;
		Item.autoReuse = false;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.StoneBlock, 20);
		recipe.AddTile(TileID.WorkBenches);
		recipe.Register();
	}
}
