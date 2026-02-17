using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class UnholyArrowSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 32;
		Item.height = 32;
		Item.scale = 1.3f;
		Item.rare = 1;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 25;
		Item.useAnimation = 25;
		Item.damage = 20;
		Item.knockBack = 5f;
		Item.UseSound = SoundID.Item5;
		Item.shoot = 4;
		Item.shootSpeed = 10f;
		Item.value = 8500;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(47, 999);
		recipe.AddIngredient(Mod, "SwordMatter", 90);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
	}
}
