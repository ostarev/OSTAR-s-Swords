using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items;

public class MartianSaucerCore : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 38;
		Item.height = 40;
		Item.maxStack = 999;
		Item.value = 400000;
		Item.rare = ItemRarityID.Yellow;
		Item.ResearchUnlockCount = 25;
	}
}
