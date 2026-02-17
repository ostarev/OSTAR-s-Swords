using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class Glamdring : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 32;
		Item.height = 32;
		Item.scale = 2f;
		Item.rare = ItemRarityID.Pink;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 15;
		Item.useAnimation = 15;
		Item.damage = 65;
		Item.knockBack = 4f;
		Item.UseSound = SoundID.Item1;
		Item.value = 98900;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "UpgradeMatter", 1);
		recipe.AddIngredient(ItemID.OrichalcumSword, 1);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
		Recipe recipe2 = CreateRecipe();
		recipe2.AddIngredient(Mod, "UpgradeMatter", 1);
		recipe2.AddIngredient(ItemID.MythrilSword, 1);
		recipe2.AddTile(TileID.MythrilAnvil);
		recipe2.Register();
	}
}
