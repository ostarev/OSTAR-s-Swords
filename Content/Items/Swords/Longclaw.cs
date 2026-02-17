using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class Longclaw : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 58;
		Item.height = 58;
		Item.scale = 1f;
		Item.rare = 2;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.knockBack = 4f;
		Item.useTime = 20;
		Item.useAnimation = 20;
		Item.damage = 20;
		Item.UseSound = SoundID.Item1;
		Item.value = 99999;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(22, 20);
		recipe.AddIngredient(Mod, "KokiriSword", 1);
		recipe.AddIngredient(Mod, "SwordMatter", 100);
		recipe.AddIngredient(3507, 1);
		recipe.AddIngredient(72, 100);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
		Recipe recipe2 = CreateRecipe();
		recipe2.AddIngredient(704, 20);
		recipe2.AddIngredient(Mod, "KokiriSword", 1);
		recipe2.AddIngredient(Mod, "SwordMatter", 100);
		recipe2.AddIngredient(3507, 1);
		recipe2.AddIngredient(72, 100);
		recipe2.AddTile(TileID.Anvils);
		recipe2.Register();
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.Frostburn, 260, false);
	}
}
