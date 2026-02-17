using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class StoneShortsword : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 38;
		Item.height = 38;
		Item.scale = 1f;
		Item.rare = ItemRarityID.Blue;
		Item.useStyle = ItemUseStyleID.Thrust;
		Item.useTime = 20;
		Item.useAnimation = 20;
		Item.damage = 5;
		Item.knockBack = 3f;
		Item.UseSound = SoundID.Item1;
		Item.value = Item.sellPrice(0, 0, 0, 20);
		Item.autoReuse = false;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.StoneBlock, 15);
		recipe.AddTile(TileID.WorkBenches);
		recipe.Register();
	}
}
