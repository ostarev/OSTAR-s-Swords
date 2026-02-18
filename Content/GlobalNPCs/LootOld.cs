using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Chat;
using Terraria.DataStructures;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.WorldBuilding;
using UniverseOfSwordsModOld.Items;

namespace UniverseOfSwordsModOld.NPCs;

public class UniverseOfSwordsModGlobalNPC : GlobalNPC
{
	public bool eBlaze;

	public override bool InstancePerEntity => true;

	public override void ResetEffects(NPC npc)
	{
		eBlaze = false;
	}

	public override void UpdateLifeRegen(NPC npc, ref int damage)
	{
		if (eBlaze)
		{
			if (npc.lifeRegen > 0)
			{
				npc.lifeRegen = 0;
			}
			npc.lifeRegen -= 120000;
			if (damage < 2)
			{
				damage = 40000;
			}
		}
	}

	public override void DrawEffects(NPC npc, ref Color drawColor)
	{
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		if (!eBlaze)
		{
			return;
		}
		if (Main.rand.Next(8) < 6)
		{
			int dust = Dust.NewDust(((Entity)npc).position - new Vector2(2f, 2f), ((Entity)npc).width + 4, ((Entity)npc).height + 4, ((ModType)this).Mod.Find<ModDust>("EmperorBlaze").Type, ((Entity)npc).velocity.X * 0.4f, ((Entity)npc).velocity.Y * 0.4f, 100, default(Color), 3.5f);
			Main.dust[dust].noGravity = true;
			Dust obj = Main.dust[dust];
			obj.velocity *= 0.5f;
			Main.dust[dust].velocity.Y -= 0.5f;
			if (Main.rand.Next(8) == 0)
			{
				Main.dust[dust].noGravity = false;
				Dust obj2 = Main.dust[dust];
				obj2.scale *= 0.7f;
			}
		}
		Lighting.AddLight(((Entity)npc).position, 0.1f, 0.2f, 0.7f);
	}

	public override void ModifyShop(NPCShop shop)
	{
		if (Utils.NextBool(Main.rand, 2) && ((AbstractNPCShop)shop).NpcType == 368)
		{
			shop.Add<Skooma>(Array.Empty<Condition>());
		}
	}

	public override void OnKill(NPC npc)
	{
		IEntitySource source = ((Entity)npc).GetSource_Loot((string)null);
		if (npc.lifeMax > 5 && npc.value > 0f)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("SwordMatter").Type, 1, false, 0, false, false);
			if (Main.expertMode && (double)Utils.NextFloat(Main.rand) < 0.25)
			{
				Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("SwordMatter").Type, 1, false, 0, false, false);
			}
		}
		if (npc.type == 4 && !Main.expertMode)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("CthulhuJudge").Type, 1, false, 0, false, false);
		}
		if (npc.type == 50 && !Main.expertMode)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("StickyGlowstickSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 15 && !Main.expertMode)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("TheEater").Type, 1, false, 0, false, false);
		}
		if (npc.type == 266 && !Main.expertMode)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("TheBrain").Type, 1, false, 0, false, false);
		}
		if (npc.type == 35 && !Main.expertMode)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("SwordOfPower").Type, 1, false, 0, false, false);
		}
		if (npc.type == 127 && !Main.expertMode)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("PrimeSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 126 && !Main.expertMode)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("TwinsSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 134 && !Main.expertMode)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("DestroyerSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 262 && !Main.expertMode)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("Executioner").Type, 1, false, 0, false, false);
		}
		if (npc.type == 245 && !Main.expertMode)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("Golem").Type, 1, false, 0, false, false);
		}
		if (npc.type == 439 && !Main.expertMode)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("Doomsday").Type, 1, false, 0, false, false);
		}
		if (npc.type == 439 && Main.expertMode)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("Doomsday").Type, 1, false, 0, false, false);
		}
		if (npc.type == 370 && !Main.expertMode)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("Sharkron").Type, 1, false, 0, false, false);
		}
		if (npc.type == 290 && !Main.expertMode && Main.rand.Next(0, 7) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("PaladinSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 290 && Main.expertMode && Main.rand.Next(0, 5) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("PaladinSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 159 && !Main.expertMode && Main.rand.Next(50) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("DraculaSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 159 && Main.expertMode && Main.rand.Next(40) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("DraculaSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 158 && !Main.expertMode && Main.rand.Next(50) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("DraculaSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 158 && Main.expertMode && Main.rand.Next(45) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("DraculaSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 395 && !Main.expertMode && Main.rand.Next(0, 2) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("MartianSaucerCore").Type, 1, false, 0, false, false);
		}
		if (npc.type == 395 && Main.expertMode && Main.rand.Next(0, 1) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("MartianSaucerCore").Type, 1, false, 0, false, false);
		}
		if (npc.type == 162 && !Main.expertMode && Main.rand.Next(0, 40) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("FingerofDoom").Type, 1, false, 0, false, false);
		}
		if (npc.type == 162 && Main.expertMode && Main.rand.Next(0, 30) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("FingerofDoom").Type, 1, false, 0, false, false);
		}
		if (npc.type == 86 && !Main.expertMode && Main.rand.Next(0, 15) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("GiantUnicornHorn").Type, 1, false, 0, false, false);
		}
		if (npc.type == 86 && Main.expertMode && Main.rand.Next(0, 10) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("GiantUnicornHorn").Type, 1, false, 0, false, false);
		}
		if (npc.type == 481 && !Main.expertMode && Main.rand.Next(0, 15) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("CaesarSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 481 && Main.expertMode && Main.rand.Next(0, 11) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("CaesarSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 491 && !Main.expertMode && Main.rand.Next(0, 5) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("DutchSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 491 && Main.expertMode && Main.rand.Next(0, 3) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("DutchSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 475 && !Main.expertMode && Main.rand.Next(0, 3) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("ShardSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 475 && Main.expertMode && Main.rand.Next(0, 2) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("ShardSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 474 && !Main.expertMode && Main.rand.Next(0, 3) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("DartSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 474 && Main.expertMode && Main.rand.Next(0, 2) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("DartSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 473 && !Main.expertMode && Main.rand.Next(0, 3) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("ClingerSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 473 && Main.expertMode && Main.rand.Next(0, 2) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("ClingerSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 476 && !Main.expertMode && Main.rand.Next(0, 3) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("RottenSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 476 && Main.expertMode && Main.rand.Next(0, 2) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("RottenSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 156 && !Main.expertMode && Main.rand.Next(0, 15) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("DevilSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 156 && Main.expertMode && Main.rand.Next(0, 13) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("DevilSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 62 && !Main.expertMode && Main.rand.Next(0, 40) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("DeathSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 62 && Main.expertMode && Main.rand.Next(0, 35) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("DeathSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 28 && !Main.expertMode && Main.rand.Next(0, 30) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("Sting").Type, 1, false, 0, false, false);
		}
		if (npc.type == 28 && Main.expertMode && Main.rand.Next(0, 25) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("Sting").Type, 1, false, 0, false, false);
		}
		if (npc.type == 422 && !Main.expertMode && Main.rand.Next(0, 5) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("InnosWrath").Type, 1, false, 0, false, false);
		}
		if (npc.type == 422 && Main.expertMode && Main.rand.Next(0, 3) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("InnosWrath").Type, 1, false, 0, false, false);
		}
		if (npc.type == 507 && !Main.expertMode && Main.rand.Next(0, 5) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("InnosWrath").Type, 1, false, 0, false, false);
		}
		if (npc.type == 507 && Main.expertMode && Main.rand.Next(0, 3) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("InnosWrath").Type, 1, false, 0, false, false);
		}
		if (npc.type == 493 && !Main.expertMode && Main.rand.Next(0, 5) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("InnosWrath").Type, 1, false, 0, false, false);
		}
		if (npc.type == 493 && Main.expertMode && Main.rand.Next(0, 3) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("InnosWrath").Type, 1, false, 0, false, false);
		}
		if (npc.type == 517 && !Main.expertMode && Main.rand.Next(0, 5) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("InnosWrath").Type, 1, false, 0, false, false);
		}
		if (npc.type == 517 && Main.expertMode && Main.rand.Next(0, 3) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("InnosWrath").Type, 1, false, 0, false, false);
		}
		if (npc.type == 422 && !Main.expertMode && Main.rand.Next(0, 5) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("BeliarClaw").Type, 1, false, 0, false, false);
		}
		if (npc.type == 422 && Main.expertMode && Main.rand.Next(0, 3) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("BeliarClaw").Type, 1, false, 0, false, false);
		}
		if (npc.type == 507 && !Main.expertMode && Main.rand.Next(0, 5) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("BeliarClaw").Type, 1, false, 0, false, false);
		}
		if (npc.type == 507 && Main.expertMode && Main.rand.Next(0, 3) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("BeliarClaw").Type, 1, false, 0, false, false);
		}
		if (npc.type == 493 && !Main.expertMode && Main.rand.Next(0, 5) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("BeliarClaw").Type, 1, false, 0, false, false);
		}
		if (npc.type == 493 && Main.expertMode && Main.rand.Next(0, 3) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("BeliarClaw").Type, 1, false, 0, false, false);
		}
		if (npc.type == 517 && !Main.expertMode && Main.rand.Next(0, 5) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("BeliarClaw").Type, 1, false, 0, false, false);
		}
		if (npc.type == 517 && Main.expertMode && Main.rand.Next(0, 3) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("BeliarClaw").Type, 1, false, 0, false, false);
		}
		if (npc.type == 26 && !Main.expertMode && Main.rand.Next(0, 20) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("GoblinKnife").Type, 1, false, 0, false, false);
		}
		if (npc.type == 26 && Main.expertMode && Main.rand.Next(0, 17) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("GoblinKnife").Type, 1, false, 0, false, false);
		}
		if (npc.type == 24 && !Main.expertMode && Main.rand.Next(0, 30) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("Fireball").Type, 1, false, 0, false, false);
		}
		if (npc.type == 24 && Main.expertMode && Main.rand.Next(0, 25) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("Fireball").Type, 1, false, 0, false, false);
		}
		if (npc.type == 93 && !Main.expertMode && Main.rand.Next(0, 50) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("BatSlayer").Type, 1, false, 0, false, false);
		}
		if (npc.type == 93 && Main.expertMode && Main.rand.Next(0, 45) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("BatSlayer").Type, 1, false, 0, false, false);
		}
		if (npc.type == 58 && !Main.expertMode && Main.rand.Next(0, 80) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("Biter").Type, 1, false, 0, false, false);
		}
		if (npc.type == 58 && Main.expertMode && Main.rand.Next(0, 70) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("Biter").Type, 1, false, 0, false, false);
		}
		if (npc.type == 71 && !Main.expertMode && Main.rand.Next(0, 10) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("SlimeKiller").Type, 1, false, 0, false, false);
		}
		if (npc.type == 71 && Main.expertMode && Main.rand.Next(0, 5) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("SlimeKiller").Type, 1, false, 0, false, false);
		}
		if (npc.type == 53 && !Main.expertMode && Main.rand.Next(0, 1) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("UselessWeapon").Type, 1, false, 0, false, false);
		}
		if (npc.type == 53 && Main.expertMode && Main.rand.Next(0, 1) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("UselessWeapon").Type, 1, false, 0, false, false);
		}
		if (npc.type == 104 && !Main.expertMode && Main.rand.Next(0, 30) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("WolfDestroyer").Type, 1, false, 0, false, false);
		}
		if (npc.type == 104 && Main.expertMode && Main.rand.Next(0, 25) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("WolfDestroyer").Type, 1, false, 0, false, false);
		}
		if (npc.type == 82 && !Main.expertMode && Main.rand.Next(0, 50) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("WraithBlade").Type, 1, false, 0, false, false);
		}
		if (npc.type == 82 && Main.expertMode && Main.rand.Next(0, 40) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("WraithBlade").Type, 1, false, 0, false, false);
		}
		if (npc.type == 3 && !Main.expertMode && Main.rand.Next(0, 50) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("ZombieKnife").Type, 1, false, 0, false, false);
		}
		if (npc.type == 3 && Main.expertMode && Main.rand.Next(0, 40) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("ZombieKnife").Type, 1, false, 0, false, false);
		}
		if (npc.type == 430 && !Main.expertMode && Main.rand.Next(0, 50) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("ZombieKnife").Type, 1, false, 0, false, false);
		}
		if (npc.type == 430 && Main.expertMode && Main.rand.Next(0, 40) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("ZombieKnife").Type, 1, false, 0, false, false);
		}
		if (npc.type == 140 && !Main.expertMode && Main.rand.Next(0, 40) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("PossessedSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 140 && Main.expertMode && Main.rand.Next(0, 35) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("PossessedSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 132 && !Main.expertMode && Main.rand.Next(0, 50) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("ZombieKnife").Type, 1, false, 0, false, false);
		}
		if (npc.type == 132 && Main.expertMode && Main.rand.Next(0, 40) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("ZombieKnife").Type, 1, false, 0, false, false);
		}
		if (npc.type == 186 && !Main.expertMode && Main.rand.Next(0, 50) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("ZombieKnife").Type, 1, false, 0, false, false);
		}
		if (npc.type == 186 && Main.expertMode && Main.rand.Next(0, 40) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("ZombieKnife").Type, 1, false, 0, false, false);
		}
		if (npc.type == 187 && !Main.expertMode && Main.rand.Next(0, 50) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("ZombieKnife").Type, 1, false, 0, false, false);
		}
		if (npc.type == 187 && Main.expertMode && Main.rand.Next(0, 40) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("ZombieKnife").Type, 1, false, 0, false, false);
		}
		if (npc.type == 188 && !Main.expertMode && Main.rand.Next(0, 50) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("ZombieKnife").Type, 1, false, 0, false, false);
		}
		if (npc.type == 188 && Main.expertMode && Main.rand.Next(0, 40) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("ZombieKnife").Type, 1, false, 0, false, false);
		}
		if (npc.type == 189 && !Main.expertMode && Main.rand.Next(0, 50) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("ZombieKnife").Type, 1, false, 0, false, false);
		}
		if (npc.type == 189 && Main.expertMode && Main.rand.Next(0, 40) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("ZombieKnife").Type, 1, false, 0, false, false);
		}
		if (npc.type == 200 && !Main.expertMode && Main.rand.Next(0, 50) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("ZombieKnife").Type, 1, false, 0, false, false);
		}
		if (npc.type == 200 && Main.expertMode && Main.rand.Next(0, 40) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("ZombieKnife").Type, 1, false, 0, false, false);
		}
		if (npc.type == 85 && !Main.expertMode && Main.rand.Next(0, 4) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("ElBastardo").Type, 1, false, 0, false, false);
		}
		if (npc.type == 85 && Main.expertMode && Main.rand.Next(0, 3) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("ElBastardo").Type, 1, false, 0, false, false);
		}
		if (npc.type == 289 && !Main.expertMode && Main.rand.Next(0, 30) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("WeirdSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 289 && Main.expertMode && Main.rand.Next(0, 20) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("WeirdSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 32 && !Main.expertMode && Main.rand.Next(0, 40) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("WaterBoltSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 32 && Main.expertMode && Main.rand.Next(0, 30) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("WaterBoltSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 48 && !Main.expertMode && Main.rand.Next(0, 30) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("FeatherDuster").Type, 1, false, 0, false, false);
		}
		if (npc.type == 48 && Main.expertMode && Main.rand.Next(0, 20) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("FeatherDuster").Type, 1, false, 0, false, false);
		}
		if (npc.type == 87 && !Main.expertMode && Main.rand.Next(0, 10) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("SkyPower").Type, 1, false, 0, false, false);
		}
		if (npc.type == 87 && Main.expertMode && Main.rand.Next(0, 5) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("SkyPower").Type, 1, false, 0, false, false);
		}
		if (npc.type == 269 && !Main.expertMode && Main.rand.Next(0, 150) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("RustySword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 269 && Main.expertMode && Main.rand.Next(0, 120) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("RustySword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 270 && !Main.expertMode && Main.rand.Next(0, 150) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("RustySword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 270 && Main.expertMode && Main.rand.Next(0, 120) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("RustySword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 271 && !Main.expertMode && Main.rand.Next(0, 150) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("RustySword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 271 && Main.expertMode && Main.rand.Next(0, 120) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("RustySword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 272 && !Main.expertMode && Main.rand.Next(0, 150) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("RustySword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 272 && Main.expertMode && Main.rand.Next(0, 120) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("RustySword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 273 && !Main.expertMode && Main.rand.Next(0, 150) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("MagnetSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 273 && Main.expertMode && Main.rand.Next(0, 120) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("MagnetSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 274 && !Main.expertMode && Main.rand.Next(0, 150) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("MagnetSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 274 && Main.expertMode && Main.rand.Next(0, 120) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("MagnetSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 275 && !Main.expertMode && Main.rand.Next(0, 150) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("MagnetSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 275 && Main.expertMode && Main.rand.Next(0, 120) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("MagnetSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 276 && !Main.expertMode && Main.rand.Next(0, 150) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("MagnetSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 276 && Main.expertMode && Main.rand.Next(0, 120) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("MagnetSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 277 && !Main.expertMode && Main.rand.Next(0, 150) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("SwordOfFlames").Type, 1, false, 0, false, false);
		}
		if (npc.type == 277 && Main.expertMode && Main.rand.Next(0, 120) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("SwordOfFlames").Type, 1, false, 0, false, false);
		}
		if (npc.type == 279 && !Main.expertMode && Main.rand.Next(0, 150) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("SwordOfFlames").Type, 1, false, 0, false, false);
		}
		if (npc.type == 279 && Main.expertMode && Main.rand.Next(0, 120) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("SwordOfFlames").Type, 1, false, 0, false, false);
		}
		if (npc.type == 280 && !Main.expertMode && Main.rand.Next(0, 150) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("SwordOfFlames").Type, 1, false, 0, false, false);
		}
		if (npc.type == 280 && Main.expertMode && Main.rand.Next(0, 120) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("SwordOfFlames").Type, 1, false, 0, false, false);
		}
		if (npc.type == 278 && !Main.expertMode && Main.rand.Next(0, 150) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("SwordOfFlames").Type, 1, false, 0, false, false);
		}
		if (npc.type == 278 && Main.expertMode && Main.rand.Next(0, 120) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("SwordOfFlames").Type, 1, false, 0, false, false);
		}
		if (npc.type == 176 && !Main.expertMode && Main.rand.Next(0, 1250) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("DragonsDeath").Type, 1, false, 0, false, false);
		}
		if (npc.type == 176 && Main.expertMode && Main.rand.Next(0, 1050) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("DragonsDeath").Type, 1, false, 0, false, false);
		}
		if (npc.type == 157 && !Main.expertMode && Main.rand.Next(0, 1250) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("DragonsDeath").Type, 1, false, 0, false, false);
		}
		if (npc.type == 157 && Main.expertMode && Main.rand.Next(0, 1050) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("DragonsDeath").Type, 1, false, 0, false, false);
		}
		if (npc.type == 226 && !Main.expertMode && Main.rand.Next(0, 1000) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("DragonsDeath").Type, 1, false, 0, false, false);
		}
		if (npc.type == 226 && Main.expertMode && Main.rand.Next(0, 900) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("DragonsDeath").Type, 1, false, 0, false, false);
		}
		if (npc.type == 67 && !Main.expertMode && Main.rand.Next(0, 50) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("OceanRoar").Type, 1, false, 0, false, false);
		}
		if (npc.type == 67 && Main.expertMode && Main.rand.Next(0, 30) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("OceanRoar").Type, 1, false, 0, false, false);
		}
		if (npc.type == 163 && !Main.expertMode && Main.rand.Next(0, 70) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("PoisonSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 163 && Main.expertMode && Main.rand.Next(0, 50) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("PoisonSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 238 && !Main.expertMode && Main.rand.Next(0, 70) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("PoisonSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 238 && Main.expertMode && Main.rand.Next(0, 50) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("PoisonSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 471 && !Main.expertMode && Main.rand.Next(0, 6) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("PhantomScimitar").Type, 1, false, 0, false, false);
		}
		if (npc.type == 471 && Main.expertMode && Main.rand.Next(0, 3) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("PhantomScimitar").Type, 1, false, 0, false, false);
		}
		if (npc.type == 482 && !Main.expertMode && Main.rand.Next(0, 30) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("WitherBane").Type, 1, false, 0, false, false);
		}
		if (npc.type == 482 && Main.expertMode && Main.rand.Next(0, 15) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("WitherBane").Type, 1, false, 0, false, false);
		}
		if (npc.type == 68 && !Main.expertMode && Main.rand.Next(0, 100) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("HaloOfHorrors").Type, 1, false, 0, false, false);
		}
		if (npc.type == 68 && Main.expertMode && Main.rand.Next(0, 100) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("HaloOfHorrors").Type, 1, false, 0, false, false);
		}
		if (npc.type == 468 && !Main.expertMode && Main.rand.Next(0, 30) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("HeisenbergsFlask").Type, 1, false, 0, false, false);
		}
		if (npc.type == 468 && Main.expertMode && Main.rand.Next(0, 20) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("HeisenbergsFlask").Type, 1, false, 0, false, false);
		}
		if (npc.type == 353 && !Main.expertMode && Main.rand.Next(4) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("Extase").Type, 1, false, 0, false, false);
		}
		if (npc.type == 353 && Main.expertMode && Main.rand.Next(2) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("Extase").Type, 1, false, 0, false, false);
		}
		if (npc.type == 398 && !Main.expertMode && Main.rand.Next(100) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("StarMaelstorm").Type, 1, false, 0, false, false);
		}
		if (npc.type == 398 && Main.expertMode && Main.rand.Next(50) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("StarMaelstorm").Type, 1, false, 0, false, false);
		}
		if (npc.type == 156 && !Main.expertMode && Main.rand.Next(0, 15) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("ScarletFlareCore").Type, 1, false, 0, false, false);
		}
		if (npc.type == 156 && Main.expertMode && Main.rand.Next(0, 10) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("ScarletFlareCore").Type, 1, false, 0, false, false);
		}
		if (npc.type == 62 && !Main.expertMode && Main.rand.Next(60) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("DaedricSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 62 && Main.expertMode && Main.rand.Next(50) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("DaedricSword").Type, 1, false, 0, false, false);
		}
		if (npc.type == 245 && !Main.expertMode && Main.rand.Next(100) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("SolBlade").Type, 1, false, 0, false, false);
		}
		if (npc.type == 245 && Main.expertMode && Main.rand.Next(75) == 0)
		{
			Item.NewItem(source, (int)((Entity)npc).position.X, (int)((Entity)npc).position.Y, ((Entity)npc).width, ((Entity)npc).height, ((ModType)this).Mod.Find<ModItem>("SolBlade").Type, 1, false, 0, false, false);
		}
	}

	public override bool PreKill(NPC npc)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		if (npc.type == 262 && !NPC.downedPlantBoss)
		{
			if (Main.netMode == 2)
			{
				ChatHelper.BroadcastChatMessage(NetworkText.FromLiteral("The world has been cursed with Black Ore"), new Color(41, 55, 41), -1);
			}
			if (Main.netMode == 0)
			{
				Main.NewText((object)"The world has been cursed with Black Ore", (Color?)new Color(41, 55, 41));
			}
			for (int i = 0; i < Main.maxTilesX / 4200 * 50; i++)
			{
				int num = WorldGen.genRand.Next(0, Main.maxTilesX);
				int Y = WorldGen.genRand.Next((int)GenVars.rockLayer, Main.maxTilesY - 300);
				Framing.GetTileSafely(num, Y);
				WorldGen.OreRunner(num, Y, (double)WorldGen.genRand.Next(8, 10), WorldGen.genRand.Next(3, 4), ((ModBlockType)((ModType)this).Mod.Find<ModTile>("BlackOreTile")).Type);
			}
		}
		return true;
	}
}
