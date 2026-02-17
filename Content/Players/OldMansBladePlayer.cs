using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using OSTARsSWORDS.Content.Items.Swords.OldMansBlade;

namespace OSTARsSWORDS.Content.Players;

public class OldMansBladePlayer : ModPlayer
{
	public int OldManBladeConsecutiveHits;
	public bool IsAwakened;
	public float AwakenedAlpha;

	public override void ResetEffects()
	{
		// If the player isn't holding the OldMansBlade, reset the consecutive-hit counter and awakened state.
		if (Player.HeldItem?.type != ModContent.ItemType<OldMansBlade>())
		{
			OldManBladeConsecutiveHits = 0;
			IsAwakened = false;
		}
	}

	public override void PostUpdate()
	{
		float fadeSpeed = 0.05f; // Adjust this for faster or slower fading
		if (IsAwakened)
		{
			AwakenedAlpha += fadeSpeed;
		}
		else
		{
			AwakenedAlpha -= fadeSpeed;
		}
		AwakenedAlpha = Microsoft.Xna.Framework.MathHelper.Clamp(AwakenedAlpha, 0f, 1f);
	}

	public override void SaveData(TagCompound tag)
	{
		tag["OldManBladeConsecutiveHits"] = OldManBladeConsecutiveHits;
	}

	public override void LoadData(TagCompound tag)
	{
		OldManBladeConsecutiveHits = tag.GetInt("OldManBladeConsecutiveHits");
	}
}