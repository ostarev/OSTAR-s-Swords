using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class KokiriSword : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 32;
		Item.height = 32;
		Item.scale = 1.6f;
		Item.rare = 2;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 15;
		Item.useAnimation = 15;
		Item.damage = 12;
		Item.knockBack = 2f;
		Item.UseSound = SoundID.Item1;
		Item.value = 9000;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(9, 30);
		recipe.AddIngredient(178, 1);
		recipe.AddIngredient(Mod, "SwordMatter", 20);
		recipe.AddTile(TileID.WorkBenches);
		recipe.Register();
	}
}
