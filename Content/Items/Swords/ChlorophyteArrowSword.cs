using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class ChlorophyteArrowSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 32;
		Item.height = 32;
		Item.scale = 1.7f;
		Item.rare = ItemRarityID.Pink;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 20;
		Item.useAnimation = 20;
		Item.damage = 68;
		Item.knockBack = 8f;
		Item.UseSound = SoundID.Item5;
		Item.shoot = ProjectileID.ChlorophyteArrow;
		Item.shootSpeed = 10f;
		Item.value = 78500;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.ChlorophyteArrow, 999);
		recipe.AddIngredient(Mod, "SwordMatter", 110);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}
}
