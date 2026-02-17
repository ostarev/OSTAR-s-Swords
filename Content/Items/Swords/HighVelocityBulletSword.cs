using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class HighVelocityBulletSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 35;
		Item.height = 35;
		Item.scale = 1.8f;
		Item.rare = ItemRarityID.Lime;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 15;
		Item.useAnimation = 15;
		Item.damage = 68;
		Item.knockBack = 4.1f;
		Item.UseSound = SoundID.Item11;
		Item.value = 130000;
		Item.shoot = ProjectileID.BulletHighVelocity;
		Item.shootSpeed = 20f;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.HighVelocityBullet, 999);
		recipe.AddIngredient(Mod, "SwordMatter", 100);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
	}
}
