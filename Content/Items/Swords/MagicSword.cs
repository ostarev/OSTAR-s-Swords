using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class MagicSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 35;
		Item.height = 35;
		Item.scale = 1.7f;
		Item.rare = 3;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 15;
		Item.useAnimation = 15;
		Item.damage = 35;
		Item.knockBack = 8.55f;
		Item.UseSound = new SoundStyle("UniverseOfSwordsModOld/Sounds/Item/Spell", (SoundType)0);
		Item.shoot = 173;
		Item.shootSpeed = 10f;
		Item.value = 110000;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "TheForce", 1);
		recipe.AddIngredient(113, 1);
		recipe.AddIngredient(Mod, "SwordMatter", 100);
		recipe.AddIngredient(Mod, "UpgradeMatter", 1);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
	}
}
