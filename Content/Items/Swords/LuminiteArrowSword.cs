using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class LuminiteArrowSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 32;
		Item.height = 32;
		Item.scale = 1.7f;
		Item.rare = ItemRarityID.Red;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 13;
		Item.useAnimation = 13;
		Item.damage = 100;
		Item.knockBack = 9f;
		Item.UseSound = SoundID.Item5;
		Item.shoot = ProjectileID.MoonlordArrow;
		Item.shootSpeed = 20f;
		Item.value = 220500;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.MoonlordArrow, 999);
		recipe.AddIngredient(Mod, "SwordMatter", 99);
		recipe.AddTile(TileID.AncientManipulator);
		recipe.Register();
	}
}
