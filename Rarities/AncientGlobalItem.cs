using Terraria;
using Terraria.ModLoader;
using OSTARsSWORDS.Rarities;

namespace OSTARsSWORDS.Rarities
{
    public class AncientGlobalItem : GlobalItem
    {
        public override bool PreDrawTooltipLine(Item item, DrawableTooltipLine line, ref int yOffset)
        {
            // Check the item name line and if it has our rarity
            if (line.Mod == "Terraria" && line.Name == "ItemName" && item.rare == ModContent.RarityType<Ancient>())
            {
                Ancient.Draw(item, line);
                return false; // Skip the default drawing
            }
            return true;
        }
    }
}
