using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class Orcrist : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 64;
		Item.height = 64;
		Item.scale = 1f;
		Item.rare = ItemRarityID.Pink;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 15;
		Item.useAnimation = 15;
		Item.damage = 73;
		Item.knockBack = 5f;
		Item.UseSound = SoundID.Item1;
		Item.value = 100900;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "UpgradeMatter", 1);
		recipe.AddIngredient(ItemID.TitaniumSword, 1);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
		Recipe recipe2 = CreateRecipe();
		recipe2.AddIngredient(Mod, "UpgradeMatter", 1);
		recipe2.AddIngredient(ItemID.AdamantiteSword, 1);
		recipe2.AddTile(TileID.MythrilAnvil);
		recipe2.Register();
	}
}
