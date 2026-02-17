using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class StickyGrenadeBlade : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 56;
		Item.height = 56;
		Item.scale = 1.3f;
		Item.rare = ItemRarityID.LightRed;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 25;
		Item.useAnimation = 25;
		Item.damage = 30;
		Item.knockBack = 8f;
		Item.UseSound = SoundID.Item1;
		Item.shoot = ProjectileID.StickyGrenade;
		Item.shootSpeed = 10f;
		Item.value = Item.sellPrice(0, 1, 0, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.Gel, 100);
		recipe.AddIngredient(ItemID.Grenade, 99);
		recipe.AddIngredient(ItemID.Wire, 20);
		recipe.AddIngredient(Mod, "DamascusBar", 15);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
	}
}
