using Terraria;
using Terraria.ModLoader;
using OSTARsSWORDS.Rarities;

namespace OSTARsSWORDS.Rarities
{
    public class RarityGlobal : GlobalItem
    {
        public override bool PreDrawTooltipLine(Item item, DrawableTooltipLine line, ref int yOffset)
        {
            // Check if this is the item name line and if it has our custom rarity
            //Ancient
            if (line.Mod == "Terraria" && line.Name == "ItemName" && item.rare == ModContent.RarityType<Ancient>())
            {
                Ancient.Draw(item, line);
                return false; // Skip the default drawing
            }
            //Inferno
            if (line.Mod == "Terraria" && line.Name == "ItemName" && item.rare == ModContent.RarityType<Inferno>())
            {
                Inferno.Draw(item, line);
                return false; // Skip the default drawing
            }
            return true;
        }
    }
}
