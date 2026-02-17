using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class Uriziel : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 110;
		Item.height = 110;
		Item.scale = 1f;
		Item.rare = 7;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 13;
		Item.useAnimation = 13;
		Item.damage = 130;
		Item.knockBack = 15f;
		Item.UseSound = SoundID.Item1;
		Item.value = Item.sellPrice(0, 30, 0, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "SwordMatter", 200);
		recipe.AddIngredient(Mod, "UpgradeMatter", 3);
		recipe.AddIngredient(Mod, "SwordShard", 1);
		recipe.AddIngredient(Mod, "WeirdSword", 1);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.Ichor, 360, false);
		target.AddBuff(BuffID.OnFire, 360, false);
	}
}
