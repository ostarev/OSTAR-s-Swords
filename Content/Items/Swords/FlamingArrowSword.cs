using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class FlamingArrowSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 32;
		Item.height = 32;
		Item.scale = 1.3f;
		Item.rare = ItemRarityID.White;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 30;
		Item.useAnimation = 30;
		Item.damage = 18;
		Item.knockBack = 4f;
		Item.UseSound = SoundID.Item5;
		Item.shoot = ProjectileID.FireArrow;
		Item.shootSpeed = 10f;
		Item.value = 4500;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.FlamingArrow, 999);
		recipe.AddIngredient(Mod, "SwordMatter", 90);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
	}
}
