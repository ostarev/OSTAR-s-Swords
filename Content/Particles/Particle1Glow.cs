using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Luminance.Core.Graphics;

namespace OSTARsSWORDS.Content.Particles;

public class Particle1Glow : Particle
{
    public override string AtlasTextureName => string.Empty; // Not using atlas

    public override BlendState BlendState => BlendState.Additive;

    public override void Update()
    {
        // Simple physics
        Position += Velocity;
        Velocity *= 0.95f;
        Rotation += RotationSpeed;
        
        // Fade out
        Opacity = 1f - LifetimeRatio;
        Scale *= 0.98f;
    }

    public override void Draw(SpriteBatch spriteBatch)
    {
        Texture2D texture = ModContent.Request<Texture2D>("OSTARsSWORDS/ExtraTextures/UI/CrystalTextSparkle").Value;
        Texture2D glowTexture = ModContent.Request<Texture2D>("OSTARsSWORDS/ExtraTextures/UI/CrystalTextGlow").Value;
        Vector2 origin = texture.Size() / 2f;
        Vector2 glowOrigin = glowTexture.Size() / 2f;

        // Draw bloom/glow first
        spriteBatch.Draw(glowTexture, Position - Main.screenPosition, null, DrawColor * Opacity * 0.6f, Rotation, glowOrigin, Scale * 2f, SpriteEffects.None, 0f);
        spriteBatch.Draw(glowTexture, Position - Main.screenPosition, null, DrawColor * Opacity * 0.6f, Rotation * MathHelper.TwoPi, glowOrigin, Scale * 2f, SpriteEffects.None, 0f);

        // Draw the main sparkle
        spriteBatch.Draw(texture, Position - Main.screenPosition, null, DrawColor * Opacity, Rotation, origin, Scale, SpriteEffects.None, 0f);
    }
}
