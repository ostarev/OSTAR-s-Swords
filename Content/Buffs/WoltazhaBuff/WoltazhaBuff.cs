using Terraria;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Buffs.WoltazhaBuff;

public class WoltazhaBuff : ModBuff
{
    public override void SetStaticDefaults()
    {
        Main.buffNoTimeDisplay[Type] = false;
        Main.buffNoSave[Type] = false;
    }

    public override void Update(Player player, ref int buffIndex)
    {
        // Increases total melee damage by 1.2x and total attack speed by 1.2x, armor by 25%, but slows the player by 20%.
        ref StatModifier damage = ref player.GetDamage(DamageClass.Melee);
        damage *= 1.2f;
        player.GetAttackSpeed(DamageClass.Melee) *= 1.2f;
        player.statDefense *= 1.25f;
        player.moveSpeed *= 0.8f;
    }
}

