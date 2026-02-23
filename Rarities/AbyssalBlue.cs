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
    public class AbyssalBlue : ModRarity
    {
        // Lowered the multiplier slightly so the deep blue doesn't blow out
        public override Color RarityColor => TextClr * 1.5f;

        public static float MaxY = 4.5f;
        public static Color BloomClr = new(0, 150, 255, 0); // A bright cyan bloom
        public static Color TextClr = new(20, 20, 180, 255); // A deep oceanic blue

        public static void Draw(Item Item, SpriteBatch spriteBatch, string text, int X, int Y, Color textColor, Color lightColor, float rotation,
            Vector2 origin, Vector2 baseScale, float time, bool renderTextSparkles, DynamicSpriteFont font)
        {
            var crystalTextGlow = ModContent.Request<Texture2D>("OSTARsSWORDS/ExtraTextures/UI/CrystalTextGlow").Value;
            var sparkle = ModContent.Request<Texture2D>("OSTARsSWORDS/ExtraTextures/UI/CrystalTextSparkle").Value;
            var fontSize = font.MeasureString(text);
            var center = fontSize / 2f;

            var glowPosition = new Vector2(X + center.X, Y + center.Y / 1.5f);
            textColor.A = 0;

            // 1. Adjusted the math for a slower, "breathing" effect
            float pulsing = 5f + (float)Math.Sin(time * 5f) * 3f;
            float baseScalePulse = 1.05f + (float)Math.Cos(time * 2f) * 0.02f;
            float floatDistance = 6f;
            float distortionAmount = 2f;

            if (renderTextSparkles)
                for (float f = 0f; f < MathHelper.TwoPi; f += 0.79f)
                {
                    // 2. Slowed down the rotation
                    float angle = f + (time * 1.5f % MathHelper.TwoPi);

                    float distortion = (float)Math.Cos((X + f * 50f + time * 5f) * 0.1f) * distortionAmount;

                    // 3. Changed the offset to move in full circles rather than just burning upwards
                    Vector2 offset = new Vector2(
                        (float)Math.Cos(angle) * pulsing + distortion,
                        (float)Math.Sin(angle) * floatDistance
                    );

                    float scaleVariation = 0.9f + 0.1f * (float)Math.Sin(time * 5f + f);
                    Vector2 scale = new Vector2(baseScalePulse * scaleVariation);

                    // Used the BloomClr for the aura instead of the TextClr
                    Color auraColor = new Color(
                        (int)(BloomClr.R * 0.6f),
                        (int)(BloomClr.G * 0.6f),
                        (int)(BloomClr.B * 0.6f),
                        (int)(BloomClr.A * 0.6f)
                    );

                    ChatManager.DrawColorCodedString(
                        spriteBatch, font, text, new Vector2(X, Y) + offset, auraColor, rotation, origin, scale
                    );
                }

            // Draw crisp center text
            ChatManager.DrawColorCodedString(
                spriteBatch, font, text, new Vector2(X, Y), textColor, rotation, origin, new Vector2(baseScalePulse)
            );

            textColor.A = 255;

            ChatManager.DrawColorCodedStringShadow(spriteBatch, font, text, new Vector2(X, Y), textColor * 1.5f, rotation, origin, baseScale);

            spriteBatch.Draw(crystalTextGlow, glowPosition, null, lightColor, rotation + MathHelper.PiOver2, new Vector2(6f, 33f),
                new Vector2(1.6f, fontSize.X / crystalTextGlow.Height * 1.2f), SpriteEffects.None, 0f);

            // 4. Replaced the black core with a white core for a neon aesthetic
            ChatManager.DrawColorCodedString(spriteBatch, font, text, new Vector2(X, Y), Color.White, rotation, origin, baseScale);

            return;
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