using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent;
using Terraria.ModLoader;
using Terraria.UI.Chat;

namespace OSTARsSWORDS.Rarities
{
    public class InfernoRed : ModRarity
    {
        // Slightly intensified orange-red for the base color
        public override Color RarityColor => TextClr * 1.5f;

        public static float MaxY = 5f;                       // Max vertical offset for floating
        public static Color BloomClr = new(255, 120, 0, 0);  // Bright orange bloom (alpha 0 for additive feel)
        public static Color TextClr = new(220, 60, 0, 255);  // Deep ember red-orange

        public static void Draw(Item Item, SpriteBatch spriteBatch, string text, int X, int Y, Color textColor, Color lightColor, float rotation,
            Vector2 origin, Vector2 baseScale, float time, bool renderTextSparkles, DynamicSpriteFont font)
        {
            // Load textures (reusing the same paths; replace with inferno-specific ones if desired)
            var crystalTextGlow = ModContent.Request<Texture2D>("OSTARsSWORDS/ExtraTextures/UI/CrystalTextGlow").Value;
            var sparkle = ModContent.Request<Texture2D>("OSTARsSWORDS/ExtraTextures/UI/CrystalTextSparkle").Value;

            var fontSize = font.MeasureString(text);
            var center = fontSize / 2f;
            var glowPosition = new Vector2(X + center.X, Y + center.Y / 1.5f);

            textColor.A = 0; // Make text color transparent for aura layers

            // Flame-like parameters: faster, more chaotic pulsing
            float flamePulse = 6f + (float)Math.Sin(time * 12f) * 4f;               // Horizontal spread varies quickly
            float verticalWave = 8f + (float)Math.Sin(time * 8f) * 3f;              // Vertical undulation
            float baseScalePulse = 1.05f + (float)Math.Sin(time * 10f) * 0.03f;     // Slight scale flicker
            float distortionAmount = 3.5f;                                          // More distortion for heat shimmer

            if (renderTextSparkles)
            {
                // Draw multiple "spark" copies in a rough circle, but with flame-like weighting
                for (float f = 0f; f < MathHelper.TwoPi; f += 0.52f) // Smaller step = more sparks
                {
                    float angle = f + (time * 2.5f % MathHelper.TwoPi); // Faster rotation

                    // Distortion based on position and time (heat shimmer)
                    float distortion = (float)Math.Cos((X + f * 30f + time * 8f) * 0.15f) * distortionAmount;

                    // Offset combines circular motion with a stronger upward bias
                    Vector2 offset = new Vector2(
                        (float)Math.Cos(angle) * flamePulse + distortion,
                        (float)Math.Sin(angle) * verticalWave - 3f // slight upward bias
                    );

                    float scaleVariation = 0.8f + 0.2f * (float)Math.Sin(time * 12f + f); // Varying spark size
                    Vector2 scale = new Vector2(baseScalePulse * scaleVariation);

                    // Interpolate aura color between orange and yellow based on angle/time
                    float t = (float)((Math.Sin(angle + time * 3f) + 1f) * 0.5f);
                    Color auraColor = Color.Lerp(new Color(255, 80, 0, 0), new Color(255, 220, 0, 0), t);

                    ChatManager.DrawColorCodedString(
                        spriteBatch, font, text, new Vector2(X, Y) + offset, auraColor, rotation, origin, scale
                    );
                }
            }

            // Draw the crisp central text with pulsing scale
            ChatManager.DrawColorCodedString(
                spriteBatch, font, text, new Vector2(X, Y), textColor, rotation, origin, new Vector2(baseScalePulse)
            );

            textColor.A = 255; // Restore alpha for shadow

            // Shadow (dark orange instead of black)
            ChatManager.DrawColorCodedStringShadow(spriteBatch, font, text, new Vector2(X, Y), textColor * 1.2f, rotation, origin, baseScale);

            // Draw the glow texture (now with a warm tint)
            spriteBatch.Draw(crystalTextGlow, glowPosition, null, lightColor * 0.8f, rotation + MathHelper.PiOver2, new Vector2(6f, 33f),
                new Vector2(1.6f, fontSize.X / crystalTextGlow.Height * 1.2f), SpriteEffects.None, 0f);

            // Optional: draw a bright core to simulate intense heat
            ChatManager.DrawColorCodedString(spriteBatch, font, text, new Vector2(X, Y), Color.White * 0.9f, rotation, origin, baseScale * 1.02f);
        }

        // Overloads for easier use (identical to AbyssalBlue structure)
        public static void Draw(Item Item, string text, int X, int Y, float rotation, Vector2 origin, Vector2 baseScale, Color? textColor = null, Color? lightColor = null, bool? renderTextSparkles = null)
        {
            Draw(Item, Main.spriteBatch, text, X, Y,
                 Colors.AlphaDarken(textColor ?? TextClr),
                 lightColor ?? BloomClr,
                 rotation, origin, baseScale,
                 Main.GlobalTimeWrappedHourly,
                 renderTextSparkles ?? true,
                 FontAssets.MouseText.Value);
        }

        public static void Draw(Item Item, DrawableTooltipLine line)
        {
            Draw(Item, line.Text, line.X, line.Y, line.Rotation, line.Origin, line.BaseScale);
        }
    }
}
