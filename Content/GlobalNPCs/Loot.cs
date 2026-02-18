using OSTARsSWORDS.Content.Items;
using OSTARsSWORDS.Content.Items.Materials;
using OSTARsSWORDS.Content.Items.Potions.SkoomaPotion;
using OSTARsSWORDS.Content.Items.Swords;
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
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<SlimeKiller>(), chanceDenominator: 300, minimumDropped: 1, maximumDropped: 1));
            // 1 in 300 chance
        }

        //Materials
        if (!npc.friendly) //Sword Matter
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<SwordMatter>(), chanceDenominator: 3, minimumDropped: 2, maximumDropped: 10));
        }

        if (npc.type == NPCID.MartianSaucerCore) //Martian Saucer Core
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MartianSaucerCore>(), chanceDenominator: 1, minimumDropped: 1, maximumDropped: 1));
        }

        //Swords
        if (npc.type == NPCID.Paladin) //Paladin Sword
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<PaladinSword>(), chanceDenominator: 10, minimumDropped: 1, maximumDropped: 1));
        }

        if (npc.type == NPCID.GiantBat) //Bat Slayer
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BatSlayer>(), chanceDenominator: 6, minimumDropped: 1, maximumDropped: 1));
        }

        if (npc.type == NPCID.EyeofCthulhu) //Cthulhu Judge
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<CthulhuJudge>(), chanceDenominator: 1, minimumDropped: 1, maximumDropped: 1));
        }

        if (npc.type == NPCID.KingSlime) //Sticky Glowstick Sword
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<StickyGlowstickSword>(), chanceDenominator: 1, minimumDropped: 1, maximumDropped: 1));
        }

        if (npc.type == NPCID.EaterofWorldsTail) //The Eater
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TheEater>(), chanceDenominator: 1, minimumDropped: 1, maximumDropped: 1));
        }

        if (npc.type == NPCID.BrainofCthulhu) //The Brain
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TheBrain>(), chanceDenominator: 1, minimumDropped: 1, maximumDropped: 1));
        }

        if (npc.type == NPCID.SkeletronHead) //Sword of Power
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<SwordOfPower>(), chanceDenominator: 1, minimumDropped: 1, maximumDropped: 1));
        }

        if (npc.type == NPCID.SkeletronPrime) //Prime Sword
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<PrimeSword>(), chanceDenominator: 1, minimumDropped: 1, maximumDropped: 1));
        }

        if (npc.type == NPCID.Spazmatism) //Twins Sword
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TwinsSword>(), chanceDenominator: 1, minimumDropped: 1, maximumDropped: 1));
        }

        if (npc.type == NPCID.TheDestroyer) //Destroyer Sword
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<DestroyerSword>(), chanceDenominator: 1, minimumDropped: 1, maximumDropped: 1));
        }

        if (npc.type == NPCID.Plantera) //Executioner
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Executioner>(), chanceDenominator: 1, minimumDropped: 1, maximumDropped: 1));
        }

        if (npc.type == NPCID.Golem) //Golem
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Golem>(), chanceDenominator: 1, minimumDropped: 1, maximumDropped: 1));
        }

        if (npc.type == NPCID.DukeFishron) //Sharkron
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Sharkron>(), chanceDenominator: 1, minimumDropped: 1, maximumDropped: 1));
        }

        if (npc.type == NPCID.CultistBoss) //Doomsday
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Doomsday>(), chanceDenominator: 1, minimumDropped: 1, maximumDropped: 1));
        }

        if (npc.type == NPCID.Vampire || npc.type == NPCID.VampireBat) //Dracula Sword
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<DraculaSword>(), chanceDenominator: 1, minimumDropped: 1, maximumDropped: 1));
        }

        if (npc.type == NPCID.Frankenstein) //Finger of Doom
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FingerOfDoom>(), chanceDenominator: 1, minimumDropped: 1, maximumDropped: 1));
        }

        if (npc.type == NPCID.Unicorn) //Giant Unicorn Horn
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GiantUnicornHorn>(), chanceDenominator: 1, minimumDropped: 1, maximumDropped: 1));
        }

        //Biome Mimic Drops
        if (npc.type == NPCID.BigMimicCorruption) npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GiantUnicornHorn>(), chanceDenominator: 1, minimumDropped: 1, maximumDropped: 1));
        if (npc.type == NPCID.BigMimicCrimson) npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GiantUnicornHorn>(), chanceDenominator: 1, minimumDropped: 1, maximumDropped: 1));
        if (npc.type == NPCID.BigMimicHallow) npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GiantUnicornHorn>(), chanceDenominator: 1, minimumDropped: 1, maximumDropped: 1));
        if (npc.type == NPCID.BigMimicJungle) npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GiantUnicornHorn>(), chanceDenominator: 1, minimumDropped: 1, maximumDropped: 1));

        //Lunar Pillar Drops
        int[] pillars = { NPCID.LunarTowerNebula, NPCID.LunarTowerSolar, NPCID.LunarTowerStardust, NPCID.LunarTowerVortex };
        if(npc.type == pillars[0] || npc.type == pillars[1] || npc.type == pillars[2] || npc.type == pillars[3] || Main.rand.Next(0,5) == 0) 
        { 
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<InnosWrath>(), chanceDenominator: 1, minimumDropped: 1, maximumDropped: 1));
        }
        if (npc.type == pillars[0] || npc.type == pillars[1] || npc.type == pillars[2] || npc.type == pillars[3] || Main.rand.Next(0, 5) == 1)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BeliarClaw>(), chanceDenominator: 1, minimumDropped: 1, maximumDropped: 1));
        }
    }
    public override void SetupTravelShop(int[] shop, ref int nextSlot)
    {
        shop[nextSlot] = ModContent.ItemType<SkoomaPotion>();
        nextSlot++;
    }
}