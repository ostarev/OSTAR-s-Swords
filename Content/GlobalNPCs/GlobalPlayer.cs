using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.GlobalNPCs
{
    public class GlobalPlayer : ModPlayer
    {
        public bool eBlaze;

        public override void ResetEffects()
        {
            eBlaze = false;
        }

        public override void UpdateBadLifeRegen()
        {
            if (eBlaze)
            {
                // In tModLoader 1.4+, lifeRegen is handled slightly differently.
                // If lifeRegen is positive, reset it to 0 before applying the burn.
                if (Player.lifeRegen > 0)
                {
                    Player.lifeRegen = 0;
                }

                Player.lifeRegenTime = 0;
                // lifeRegen -= 40000 results in 20,000 damage per second.
                Player.lifeRegen -= 40000;
            }
        }

        public override void DrawEffects(PlayerDrawSet drawInfo, ref float r, ref float g, ref float b, ref float a, ref bool fullBright)
        {
            if (eBlaze)
            {
                // Only spawn dust if the player isn't a "shadow" (afterimage)
                if (Main.rand.NextBool(8) && drawInfo.shadow == 0f)
                {
                    int dustType = Mod.Find<ModDust>("EmperorBlazeDust").Type;
                    int dust = Dust.NewDust(drawInfo.Position - new Vector2(2f, 2f), Player.width + 4, Player.height + 4, dustType, Player.velocity.X * 0.4f, Player.velocity.Y * 0.4f, 100, default, 3f);

                    Main.dust[dust].noGravity = true;
                    Main.dust[dust].velocity *= 0.8f;
                    Main.dust[dust].velocity.Y -= 0.5f;
                    Main.dust[dust].noGravity = false;
                }

                // Shifting player color tint towards orange/red
                r *= 1f;
                g *= 0.5f;
                b *= 0f;
                fullBright = true;
            }
        }
    }
}