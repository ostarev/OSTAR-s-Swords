using Microsoft.Xna.Framework;
using OSTARsSWORDS.Content.Items.Materials;
using System.Collections.Generic;
using System.Threading;
using Terraria;
using Terraria.Chat;
using Terraria.ID;
using Terraria.IO;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace OSTARsSWORDS.Content.Spawners;

public class DamascusOreSpawnSystem : ModSystem
{
    public override void ModifyWorldGenTasks(List<GenPass> tasks, ref double totalWeight)
    {
        // Most vanilla ores are generated in a step called "Shinies", so find that step.
        int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));

        if (ShiniesIndex != -1)
        {
            // Insert our pass directly after the original "Shinies" pass.
            tasks.Insert(ShiniesIndex + 1, new OrePass("Damascus Ore Pass", 237.4298f));
        }
    }

    public class OrePass : GenPass
    {
        public OrePass(string name, float loadWeight) : base(name, loadWeight)
        {
        }

        protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
        {
            // Ores are simple: use a for loop and WorldGen.TileRunner to place splotches.
            // 6E-05 = 0.00006
            for (int k = 0; k < (int)(Main.maxTilesX * Main.maxTilesY * 6E-05); k++)
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)GenVars.rockLayer, Main.maxTilesY);

                WorldGen.TileRunner(x, y, WorldGen.genRand.Next(4, 10), WorldGen.genRand.Next(2, 6), ModContent.TileType<DamascusOreTile>());
            }
        }
    }
}
