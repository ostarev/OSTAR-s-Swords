using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class CopperCoinSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 56;
		Item.height = 56;
		Item.scale = 0.8f;
		Item.rare = 0;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 20;
		Item.useAnimation = 20;
		Item.damage = 2;
		Item.knockBack = 2f;
		Item.UseSound = SoundID.Item11;
		Item.shoot = 158;
		Item.shootSpeed = 10f;
		Item.value = 500;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(71, 99);
		recipe.AddIngredient(Mod, "SwordMatter", 10);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
	}
}
