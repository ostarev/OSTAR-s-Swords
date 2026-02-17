using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using OSTARsSWORDS.Content.Projectiles;

namespace OSTARsSWORDS.Content.Items.Swords;

public class VugarMutater : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 35;
		Item.height = 35;
		Item.scale = 1.2f;
		Item.rare = ItemRarityID.Red;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 13;
		Item.useAnimation = 13;
		Item.damage = 214;
		Item.knockBack = 6f;
		Item.UseSound = SoundID.Item1;
		Item.shoot = ModContent.ProjectileType<OSTARsSWORDS.Content.Projectiles.VugarMutater>();
		Item.shootSpeed = 40f;
		Item.value = 750000;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override Vector2? HoldoutOffset()
	{
		return new Vector2(12f, 0f);
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.TrueNightsEdge, 1);
		recipe.AddIngredient(Mod, "SwordMatter", 150);
		recipe.AddIngredient(Mod, "UpgradeMatter", 2);
		recipe.AddIngredient(ItemID.TerraBlade, 1);
		recipe.AddIngredient(ItemID.IceTorch, 50);
		recipe.AddTile(TileID.LunarCraftingStation);
		recipe.Register();
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.Frostburn, 360, false);
	}
}
