using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class WaterBoltSword : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 32;
		Item.height = 32;
		Item.scale = 1.9f;
		Item.rare = 4;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 32;
		Item.useAnimation = 32;
		Item.damage = 15;
		Item.knockBack = 6f;
		Item.shoot = 27;
		Item.shootSpeed = 10f;
		Item.UseSound = SoundID.Item1;
		Item.value = 48500;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}
}
