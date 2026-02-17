using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.GlobalNPCs;

public class Loot : GlobalNPC
{
	public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
	{
		if (npc.type == NPCID.GreenSlime || npc.type == NPCID.BlueSlime || npc.type == NPCID.PurpleSlime || npc.type == NPCID.RedSlime) //Gel Blade
		{
			npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.Swords.PreWOF.SlimeKiller>(), chanceDenominator: 300, minimumDropped: 1, maximumDropped: 1));
            // 1 in 300 chance
        }

        if(!npc.friendly) //Sword Matter
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.Materials.SwordMatter>(), chanceDenominator: 3, minimumDropped: 2, maximumDropped: 10));
        }

        if (npc.type == NPCID.Paladin) //Paladin Sword
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.Swords.PostWOF.PaladinSword>(), chanceDenominator: 10, minimumDropped: 1, maximumDropped: 1));
        }

        if (npc.type == NPCID.GiantBat) //Bat Slayer
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.Swords.PostWOF.BatSlayer>(), chanceDenominator: 6, minimumDropped: 1, maximumDropped: 1));
        }

        if(npc.type == NPCID.EyeofCthulhu && Main.expertMode) //Eye of Cthulhu Sword - EXPERT 
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.Swords.PostWOF.BatSlayer>(), chanceDenominator: 1, minimumDropped: 1, maximumDropped: 1));
        }
    }
}