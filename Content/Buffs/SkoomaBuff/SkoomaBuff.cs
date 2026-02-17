using Terraria;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Buffs.SkoomaBuff;

public class SkoomaBuff : ModBuff
{
	public override void SetStaticDefaults()
	{
		Main.buffNoTimeDisplay[Type] = false;
		Main.buffNoSave[Type] = false;
	}

	public override void Update(Player player, ref int buffIndex)
	{
		player.moveSpeed += 0.5f;
		player.maxRunSpeed += 13.37f;
		player.jumpBoost = true;
		player.jumpSpeedBoost += 13.37f;
		player.extraFall += 45;
	}
}
