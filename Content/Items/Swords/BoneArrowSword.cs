using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class BoneArrowSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 32;
		Item.height = 32;
		Item.scale = 1.4f;
		Item.rare = 2;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 25;
		Item.useAnimation = 25;
		Item.damage = 22;
		Item.knockBack = 6f;
		Item.UseSound = SoundID.Item5;
		Item.shoot = 117;
		Item.shootSpeed = 10f;
		Item.value = 14800;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(3003, 999);
		recipe.AddIngredient(Mod, "SwordMatter", 100);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
	}
}
