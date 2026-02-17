using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class OnyxSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 32;
		Item.height = 32;
		Item.scale = 1.5f;
		Item.rare = ItemRarityID.LightPurple;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 20;
		Item.useAnimation = 20;
		Item.damage = 40;
		Item.knockBack = 7.7f;
		Item.shoot = ProjectileID.BlackBolt;
		Item.shootSpeed = 15f;
		Item.UseSound = SoundID.Item1;
		Item.value = 70500;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "SwordMatter", 170);
		recipe.AddIngredient(Mod, "UpgradeMatter", 1);
		recipe.AddIngredient(ItemID.OnyxBlaster, 1);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}
}
