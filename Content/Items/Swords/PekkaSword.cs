using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class PekkaSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 56;
		Item.height = 62;
		Item.scale = 1f;
		Item.rare = ItemRarityID.Blue;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 22;
		Item.useAnimation = 22;
		Item.damage = 25;
		Item.knockBack = 4f;
		Item.UseSound = SoundID.Item1;
		Item.value = 10000;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.GoldBroadsword, 1);
		recipe.AddIngredient(Mod, "UpgradeMatter", 1);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
		Recipe recipe2 = CreateRecipe();
		recipe2.AddIngredient(ItemID.PlatinumBroadsword, 1);
		recipe2.AddIngredient(Mod, "UpgradeMatter", 1);
		recipe2.AddTile(TileID.Anvils);
		recipe2.Register();
	}
}
