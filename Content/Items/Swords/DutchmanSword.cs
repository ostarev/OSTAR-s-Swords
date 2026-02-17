using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class DutchmanSword : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 35;
		Item.height = 35;
		Item.scale = 2.1f;
		Item.rare = ItemRarityID.LightPurple;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 25;
		Item.useAnimation = 25;
		Item.damage = 40;
		Item.knockBack = 7.77f;
		Item.UseSound = SoundID.Item1;
		Item.shoot = ProjectileID.CannonballFriendly;
		Item.shootSpeed = 20f;
		Item.value = Item.sellPrice(0, 10, 0, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}
}
