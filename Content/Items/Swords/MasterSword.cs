using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class MasterSword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 64;
		Item.height = 64;
		Item.scale = 1f;
		Item.rare = ItemRarityID.Orange;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 23;
		Item.useAnimation = 25;
		Item.damage = 25;
		Item.knockBack = 4.1f;
		Item.UseSound = SoundID.Item1;
		Item.value = 9800;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "SwordMatter", 80);
		recipe.AddRecipeGroup("IronBar", 20);
		recipe.AddIngredient(ItemID.CopperBroadsword, 1);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
		Recipe recipe2 = CreateRecipe();
		recipe2.AddIngredient(Mod, "SwordMatter", 80);
		recipe2.AddRecipeGroup("IronBar", 20);
		recipe2.AddIngredient(ItemID.TinBroadsword, 1);
		recipe2.AddTile(TileID.Anvils);
		recipe2.Register();
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.Midas, 360, false);
	}
}
