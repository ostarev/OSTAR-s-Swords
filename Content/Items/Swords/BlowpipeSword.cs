using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class BlowpipeSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 38;
		Item.height = 36;
		Item.scale = 1.2f;
		Item.rare = 2;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 23;
		Item.useAnimation = 23;
		Item.damage = 16;
		Item.knockBack = 3.5f;
		Item.UseSound = SoundID.Item17;
		Item.shoot = 51;
		Item.shootSpeed = 20f;
		Item.value = Item.sellPrice(0, 0, 40, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(281, 1);
		recipe.AddIngredient(Mod, "DamascusBar", 10);
		recipe.AddIngredient(Mod, "SwordMatter", 40);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
	}
}
