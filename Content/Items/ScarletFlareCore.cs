using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items;

public class ScarletFlareCore : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 30;
		Item.height = 50;
		Item.maxStack = 99;
		Item.value = Item.sellPrice(0, 1, 0, 0);
		Item.rare = ItemRarityID.Red;
		Item.ResearchUnlockCount = 25;
	}
}
