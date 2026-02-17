using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class ShadowbeamSword : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 32;
		Item.height = 32;
		Item.scale = 1.1f;
		Item.rare = ItemRarityID.Yellow;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 20;
		Item.useAnimation = 20;
		Item.damage = 68;
		Item.knockBack = 6f;
		Item.UseSound = SoundID.Item72;
		Item.shoot = ProjectileID.ShadowBeamFriendly;
		Item.shootSpeed = 10f;
		Item.value = 510500;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.ShadowbeamStaff, 1);
		recipe.AddIngredient(Mod, "UpgradeMatter", 1);
		recipe.AddIngredient(Mod, "SwordMatter", 130);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}
}
