using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using OSTARsSWORDS.Content.Buffs.SkoomaBuff;

namespace OSTARsSWORDS.Content.Items.Potions.SkoomaPotion;

public class SkoomaPotion : ModItem
{
	public override void SetDefaults()
	{
		Item.UseSound = SoundID.Item3;
		Item.useStyle = ItemUseStyleID.DrinkLiquid;
		Item.useTurn = true;
		Item.useAnimation = 17;
		Item.useTime = 17;
		Item.maxStack = 30;
		Item.consumable = true;
		Item.width = 22;
		Item.height = 40;
		Item.value = Item.sellPrice(0, 2, 0, 0);
		Item.rare = ItemRarityID.Purple;
		Item.buffType = ModContent.BuffType<SkoomaBuff>();
		Item.buffTime = 8000;
		Item.ResearchUnlockCount = 20;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.PurpleMucos, 1);
		recipe.AddIngredient(ItemID.CandyCorn, 10);
		recipe.AddIngredient(ItemID.Moonglow, 1);
		recipe.AddTile(TileID.AlchemyTable);
		recipe.Register();
	}
}
