using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class DevilBlade : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 35;
		Item.height = 35;
		Item.scale = 2.2f;
		Item.rare = 7;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 18;
		Item.useAnimation = 18;
		Item.damage = 74;
		Item.knockBack = 7f;
		Item.UseSound = SoundID.Item8;
		Item.shoot = 114;
		Item.shootSpeed = 10f;
		Item.value = 351200;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}
}
