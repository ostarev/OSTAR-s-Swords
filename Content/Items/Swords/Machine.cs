using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class Machine : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 62;
		Item.height = 62;
		Item.scale = 1f;
		Item.rare = 7;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 20;
		Item.useAnimation = 20;
		Item.damage = 62;
		Item.knockBack = 3.5f;
		Item.UseSound = SoundID.Item1;
		Item.value = Item.sellPrice(0, 10, 0, 0);
		Item.shoot = 616;
		Item.shootSpeed = 10f;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
		recipe.AddIngredient(Mod, "Orichalcon", 1);
		recipe.AddIngredient(Mod, "UpgradeMatter", 1);
		recipe.AddIngredient(514, 1);
		recipe.AddIngredient(Mod, "PrimeSword", 1);
		recipe.AddIngredient(Mod, "DestroyerSword", 1);
		recipe.AddIngredient(Mod, "TwinsSword", 1);
		recipe.AddIngredient(Mod, "SwordMatter", 200);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}
}
