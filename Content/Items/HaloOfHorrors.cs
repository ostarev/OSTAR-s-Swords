using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items;

public class HaloOfHorrors : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 162;
		Item.height = 162;
		Item.value = Item.sellPrice(1, 0, 0, 0);
		Item.rare = ItemRarityID.Purple;
		Item.expert = true;
		Item.accessory = true;
		Item.ResearchUnlockCount = 1;
	}

	public override void UpdateAccessory(Player player, bool hideVisual)
	{
		player.statDefense += 100;
		player.GetArmorPenetration(DamageClass.Generic) += 100f;
		player.lifeRegen += 40;
		player.GetAttackSpeed(DamageClass.Melee) -= 0.3f;
		player.statLifeMax2 += 2000;
		ref StatModifier damage = ref player.GetDamage(DamageClass.Melee);
		damage += 0.15f;
		ref StatModifier damage2 = ref player.GetDamage(DamageClass.Magic);
		damage2 += 0.15f;
		ref StatModifier damage3 = ref player.GetDamage(DamageClass.Throwing);
		damage3 += 0.15f;
		ref StatModifier damage4 = ref player.GetDamage(DamageClass.Summon);
		damage4 += 0.15f;
		ref StatModifier damage5 = ref player.GetDamage(DamageClass.Ranged);
		damage5 += 0.15f;
		player.AddBuff(BuffID.PotionSickness, 2, true, false);
	}
}
