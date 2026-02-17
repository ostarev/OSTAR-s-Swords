using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class GoldCoinSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 72;
		Item.height = 72;
		Item.scale = 0.8f;
		Item.rare = 3;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 15;
		Item.useAnimation = 15;
		Item.damage = 10;
		Item.knockBack = 6f;
		Item.UseSound = SoundID.Item11;
		Item.shoot = 160;
		Item.shootSpeed = 10f;
		Item.value = 10000;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(73, 20);
		recipe.AddIngredient(Mod, "SwordMatter", 50);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
	}
}
