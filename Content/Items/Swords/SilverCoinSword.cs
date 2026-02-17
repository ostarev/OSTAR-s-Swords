using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class SilverCoinSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 58;
		Item.height = 58;
		Item.scale = 0.9f;
		Item.rare = ItemRarityID.Blue;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 20;
		Item.useAnimation = 20;
		Item.damage = 5;
		Item.knockBack = 4f;
		Item.UseSound = SoundID.Item11;
		Item.shoot = ProjectileID.SilverCoin;
		Item.shootSpeed = 10f;
		Item.value = 1500;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.SilverCoin, 99);
		recipe.AddIngredient(Mod, "SwordMatter", 20);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
	}
}
