using Terraria;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Buffs.NordMeadBuff;

public class NordMeadBuff : ModBuff
{
    public override void SetStaticDefaults()
    {
        Main.buffNoTimeDisplay[Type] = false;
        Main.buffNoSave[Type] = false;
    }

    public override void Update(Player player, ref int buffIndex)
	{
		player.GetCritChance(DamageClass.Generic) += 5f;
		ref StatModifier damage = ref player.GetDamage(DamageClass.Melee);
		damage += 0.15f;
		player.GetAttackSpeed(DamageClass.Melee) += 0.20f;
		player.endurance += 0.25f;
		player.statDefense -= 8;
	}
}
