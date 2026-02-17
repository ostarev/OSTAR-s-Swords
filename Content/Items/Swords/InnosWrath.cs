using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class InnosWrath : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 124;
		Item.height = 124;
		Item.scale = 1.5f;
		Item.rare = ItemRarityID.Red;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 20;
		Item.useAnimation = 20;
		Item.damage = 100;
		Item.knockBack = 12f;
		Item.UseSound = SoundID.Item1;
		Item.value = 611500;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.Midas, 360, false);
		target.AddBuff(BuffID.Ichor, 360, false);
		target.AddBuff(BuffID.Frostburn, 360, false);
		target.AddBuff(BuffID.OnFire, 360, false);
	}
}
