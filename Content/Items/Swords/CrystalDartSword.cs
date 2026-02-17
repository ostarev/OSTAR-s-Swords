using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class CrystalDartSword : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 35;
		Item.height = 35;
		Item.scale = 2f;
		Item.rare = ItemRarityID.LightPurple;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 20;
		Item.useAnimation = 20;
		Item.damage = 59;
		Item.knockBack = 6f;
		Item.UseSound = SoundID.Item99;
		Item.shoot = ProjectileID.CrystalDart;
		Item.shootSpeed = 20f;
		Item.value = 311200;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "SwordMatter", 125);
		recipe.AddIngredient(Mod, "UpgradeMatter", 1);
		recipe.AddIngredient(ItemID.CrystalDart, 999);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}
}
