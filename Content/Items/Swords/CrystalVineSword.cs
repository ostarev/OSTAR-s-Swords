using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class CrystalVineSword : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 46;
		Item.height = 46;
		Item.scale = 1f;
		Item.rare = ItemRarityID.LightPurple;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 20;
		Item.useAnimation = 20;
		Item.damage = 64;
		Item.knockBack = 6f;
		Item.UseSound = SoundID.Item101;
		Item.shoot = ProjectileID.CrystalVileShardShaft;
		Item.shootSpeed = 8f;
		Item.value = Item.sellPrice(0, 10, 0, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}
}
