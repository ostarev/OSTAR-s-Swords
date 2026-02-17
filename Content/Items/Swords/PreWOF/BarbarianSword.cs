using OSTARsSWORDS.Content.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords.PreWOF;

public class BarbarianSword : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 58;
		Item.height = 58;
		Item.scale = 1f;
		Item.rare = ItemRarityID.Blue;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 24;
		Item.useAnimation = 24;
		Item.damage = 20;
		Item.knockBack = 3f;
		Item.UseSound = SoundID.Item1;
		Item.value = 15000;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.IronBroadsword);
		recipe.AddIngredient(ModContent.ItemType<UpgradeMatter>());
		recipe.AddTile(TileID.Anvils);
		recipe.Register(); 

		Recipe recipe2 = CreateRecipe();
		recipe2.AddIngredient(ItemID.LeadBroadsword);
		recipe2.AddIngredient(ModContent.ItemType<UpgradeMatter>());
		recipe2.AddTile(TileID.Anvils);
		recipe2.Register();
	}
}
