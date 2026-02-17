using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Materials;

public class DamascusOre : ModItem
{
    public override void SetStaticDefaults()
    {
        ItemID.Sets.OreDropsFromSlime[Type] = (3, 20);
		ItemID.Sets.SortingPriorityMaterials[Type] = 60;
    }
	public override void SetDefaults()
	{
		Item.width = 16;
		Item.height = 16;
		Item.value = 500;
		Item.rare = ItemRarityID.Green;
		Item.maxStack = 9999;
		Item.ResearchUnlockCount = 100;

		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTurn = true;
		Item.useAnimation = 15;
		Item.useTime = 10;
		Item.autoReuse = true;
		Item.consumable = true;

		Item.createTile = ModContent.TileType<DamascusOreTile>();
	}
}
