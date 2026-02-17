using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using OSTARsSWORDS.Content.Projectiles;

namespace OSTARsSWORDS.Content.Items.Swords;

public class FeatherDuster : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 36;
		Item.height = 36;
		Item.scale = 1.2f;
		Item.rare = ItemRarityID.Blue;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 25;
		Item.useAnimation = 25;
		Item.damage = 18;
		Item.knockBack = 1.5f;
		Item.UseSound = SoundID.Item1;
		Item.shoot = ModContent.ProjectileType<HarpyFeather>();
		Item.shootSpeed = 10f;
		Item.value = Item.sellPrice(0, 0, 14, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}
}
