using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using OSTARsSWORDS.Content.Projectiles;

namespace OSTARsSWORDS.Content.Items.Swords;

public class HumanBuzzSaw : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.damage = 24;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
		Item.width = 106;
		Item.height = 106;
		Item.crit = 8;
		Item.scale = 2f;
		Item.useTime = 4;
		Item.useAnimation = 4;
		Item.channel = true;
		Item.UseSound = SoundID.Item1;
		Item.useStyle = 100;
		Item.knockBack = 5f;
		Item.value = Item.sellPrice(0, 5, 0, 0);
		Item.rare = ItemRarityID.LightRed;
		Item.shoot = ModContent.ProjectileType<HumanBuzzSaw>();
		Item.noUseGraphic = true;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.Sawmill, 1);
		recipe.AddIngredient(ItemID.TitaniumBar, 8);
		recipe.AddIngredient(Mod, "SwordMatter", 60);
		recipe.AddIngredient(Mod, "DamascusBar", 20);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
		Recipe recipe2 = CreateRecipe();
		recipe2.AddIngredient(ItemID.Sawmill, 1);
		recipe2.AddIngredient(ItemID.AdamantiteBar, 8);
		recipe2.AddIngredient(Mod, "SwordMatter", 60);
		recipe2.AddIngredient(Mod, "DamascusBar", 20);
		recipe2.AddTile(TileID.MythrilAnvil);
		recipe2.Register();
	}
}
