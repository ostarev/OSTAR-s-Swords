using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using OSTARsSWORDS.Content.Buffs.LesserMeleeBuff;

namespace OSTARsSWORDS.Content.Items.Potions.LesserMeleePotion;

public class LesserMeleePowerPotion : ModItem
{
	public override void SetStaticDefaults()
	{
		// Localization handled in Localization/en-US_Mods.OSTARsSWORDS.hjson
	}

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
		Item.height = 26;
		Item.value = Item.sellPrice(0, 0, 5, 0);
		Item.rare = ItemRarityID.Orange;
		Item.buffType = ModContent.BuffType<LesserMeleePower>();
		Item.buffTime = 14400; 
		Item.ResearchUnlockCount = 20;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe(); 
		recipe.AddIngredient(Mod, "SwordMatter", 10);
		recipe.AddTile(TileID.Bottles); 
		recipe.Register();
	}
}
