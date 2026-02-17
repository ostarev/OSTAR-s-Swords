using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class DesertSword : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 32;
		Item.height = 32;
		Item.scale = 1.6f;
		Item.rare = ItemRarityID.Orange;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 30;
		Item.useAnimation = 30;
		Item.damage = 26;
		Item.knockBack = 5f;
		Item.UseSound = SoundID.Item1;
		Item.value = Item.sellPrice(0, 0, 10, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.AntlionMandible, 5);
		recipe.AddIngredient(ItemID.SandBlock, 50);
		recipe.AddIngredient(Mod, "SwordMatter", 40);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
	}
}
