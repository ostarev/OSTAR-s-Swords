using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class PumpkinBoom : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 32;
		Item.height = 32;
		Item.scale = 2f;
		Item.rare = ItemRarityID.Yellow;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 20;
		Item.useAnimation = 20;
		Item.damage = 65;
		Item.knockBack = 7f;
		Item.UseSound = SoundID.Item1;
		Item.shoot = ProjectileID.JackOLantern;
		Item.shootSpeed = 10f;
		Item.value = 360500;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.JackOLanternLauncher, 1);
		recipe.AddIngredient(Mod, "Orichalcon", 1);
		recipe.AddIngredient(Mod, "SwordMatter", 100);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}
}
