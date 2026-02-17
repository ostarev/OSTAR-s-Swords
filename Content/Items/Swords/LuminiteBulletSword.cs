using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class LuminiteBulletSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 35;
		Item.height = 35;
		Item.scale = 1.8f;
		Item.rare = ItemRarityID.Red;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 13;
		Item.useAnimation = 13;
		Item.damage = 100;
		Item.knockBack = 6.55f;
		Item.UseSound = SoundID.Item11;
		Item.value = 325000;
		Item.shoot = ProjectileID.MoonlordBullet;
		Item.shootSpeed = 20f;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.MoonlordBullet, 999);
		recipe.AddIngredient(Mod, "SwordMatter", 99);
		recipe.AddTile(TileID.AncientManipulator);
		recipe.Register();
	}
}
