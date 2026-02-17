using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class GemSlayer : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 35;
		Item.height = 35;
		Item.scale = 1.5f;
		Item.rare = 3;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 24;
		Item.useAnimation = 24;
		Item.damage = 29;
		Item.knockBack = 5.7f;
		Item.UseSound = SoundID.Item1;
		Item.value = 20000;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "TopazSword", 1);
		recipe.AddIngredient(Mod, "SapphireSword", 1);
		recipe.AddIngredient(Mod, "EmeraldSword", 1);
		recipe.AddIngredient(Mod, "AmethystSword", 1);
		recipe.AddIngredient(Mod, "EmeraldSword", 1);
		recipe.AddIngredient(Mod, "AmberSword", 1);
		recipe.AddIngredient(Mod, "DiamondSword", 1);
		recipe.AddIngredient(Mod, "RubySword", 1);
		recipe.AddIngredient(Mod, "SwordMatter", 60);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(72, 360, false);
	}
}
