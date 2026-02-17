using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria.GameContent;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI.Chat;
using Terraria.ID;

namespace OSTARsSWORDS.Rarities
{
    public class Ancient : ModRarity
    {
        public override Color RarityColor => new Color(TextClr.R, TextClr.G, TextClr.B, 255);

        public static float MaxY = 4.5f;
        public static Color BloomClr = new Color(48, 33, 4, 0);
        public static Color TextClr = new Color(139, 69, 19, 255);
        static float lastFlashTime = 0f;
        static bool isFlashing = false;
        public static void Draw(Item Item, SpriteBatch spriteBatch, string text, int X, int Y, Color textColor, Color lightColor, float rotation,
        Vector2 origin, Vector2 baseScale, float time, bool renderTextSparkles, DynamicSpriteFont font)
        {
            // Define the Pulse Colors
            Color brownDark = new Color(100, 50, 10);
            Color brownBloom = Color.Lerp(brownDark, BloomClr, 0.5f); // Yellowish white bloom

            // Calculate the seamless sine wave (0.0 to 1.0)
            float sineFn = (float)Math.Sin(time * 5f);  // 1.5f is the speed of the pulse
            float t = (sineFn + 1f) / 2f; 

            // Interpolate the main text color between dark and bloom
            Color currentColor = Color.Lerp(brownDark, brownBloom, t);

            // Calculate the glow offset (expands when blooming)
            float glowOffset = 1f + t * 2f; 
            
            // Draw the outer glow (Bloom effect)
            // We draw multiple copies around the center to create the "bloom"
            Color glowColor = currentColor * 0.6f; // Slightly dimmer than the text
            glowColor.A = 0; // Use additive blending logic (low alpha usually helps in Terraria's text drawing)

            for (float f = 0f; f < MathHelper.TwoPi; f += 0.79f)
            {
                Vector2 drawPos = new Vector2(X, Y) + new Vector2(glowOffset, 0f).RotatedBy(f);
                ChatManager.DrawColorCodedString(
                    spriteBatch, font, text, 
                    drawPos, 
                    glowColor, 
                    rotation, origin, baseScale);
            }

            // Draw the Main Text
            // We use the full currentColor (Alpha 255) for the text itself
            ChatManager.DrawColorCodedString(spriteBatch, font, text, new Vector2(X, Y), currentColor, rotation, origin, baseScale);
        }

        public static void Draw(Item Item, string text, int X, int Y, float rotation, Vector2 origin, Vector2 baseScale, Color? textColor = null, Color? lightColor = null, bool? renderTextSparkles = null)
        {
            Draw(Item, Main.spriteBatch, text, X, Y, Colors.AlphaDarken(textColor ?? TextClr), lightColor ?? BloomClr, rotation, origin, baseScale, Main.GlobalTimeWrappedHourly,
                renderTextSparkles ?? true, FontAssets.MouseText.Value);
        }

        public static void Draw(Item Item, DrawableTooltipLine line)
        {
            Draw(Item, line.Text, line.X, line.Y, line.Rotation, line.Origin, line.BaseScale);
        }
    }
}
