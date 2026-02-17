using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Potions.NordMeadPotion;

public class NordMeadPotion : ModItem
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
		Item.width = 20;
		Item.height = 36;
		Item.value = Item.sellPrice(silver: 20);
		Item.rare = ItemRarityID.Orange;
		Item.buffType = ModContent.BuffType<Buffs.NordMeadBuff.NordMeadBuff>();
		Item.buffTime = 3600 * 5;
		Item.ResearchUnlockCount = 20;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.BottledHoney, 1);
		recipe.AddIngredient(ItemID.Seed, 10);
		recipe.AddTile(TileID.Kegs);
		recipe.Register();
	}
}
