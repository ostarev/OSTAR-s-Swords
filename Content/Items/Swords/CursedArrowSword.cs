using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class CursedArrowSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 32;
		Item.height = 32;
		Item.scale = 1.7f;
		Item.rare = 5;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 22;
		Item.useAnimation = 22;
		Item.damage = 55;
		Item.knockBack = 5f;
		Item.UseSound = SoundID.Item5;
		Item.shoot = 103;
		Item.shootSpeed = 10f;
		Item.value = 38500;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(545, 999);
		recipe.AddIngredient(Mod, "SwordMatter", 110);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}
}
