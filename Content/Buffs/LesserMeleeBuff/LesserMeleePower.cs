using Terraria;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Buffs.LesserMeleeBuff;

public class LesserMeleePower : ModBuff
{
    public override void SetStaticDefaults()
    {
        Main.buffNoTimeDisplay[Type] = false;
        Main.buffNoSave[Type] = false;
    }

    public override void Update(Player player, ref int buffIndex)
    {
        player.GetCritChance(DamageClass.Melee) += 5f;
        ref StatModifier damage = ref player.GetDamage(DamageClass.Melee);
        damage += 0.1f;
        player.GetAttackSpeed(DamageClass.Melee) += 0.1f;
    }
}
