using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class NanoBulletSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 35;
		Item.height = 35;
		Item.scale = 2.1f;
		Item.rare = 7;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 13;
		Item.useAnimation = 13;
		Item.damage = 72;
		Item.knockBack = 4.1f;
		Item.UseSound = SoundID.Item11;
		Item.value = 155000;
		Item.shoot = 285;
		Item.shootSpeed = 20f;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(1350, 999);
		recipe.AddIngredient(Mod, "SwordMatter", 100);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
	}
}
