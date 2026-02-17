using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class Ice : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 64;
		Item.height = 64;
		Item.scale = 1.5f;
		Item.rare = 7;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 12;
		Item.useAnimation = 12;
		Item.damage = 100;
		Item.knockBack = 7f;
		Item.UseSound = SoundID.Item1;
		Item.value = 200000;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "UpgradeMatter", 3);
		recipe.AddIngredient(Mod, "SwordShard", 1);
		recipe.AddIngredient(Mod, "Orichalcon", 1);
		recipe.AddIngredient(Mod, "Orcrist", 1);
		recipe.AddIngredient(Mod, "Glamdring", 1);
		recipe.AddIngredient(Mod, "Sting", 1);
		recipe.AddIngredient(177, 10);
		recipe.AddIngredient(178, 10);
		recipe.AddIngredient(179, 10);
		recipe.AddIngredient(180, 10);
		recipe.AddIngredient(181, 10);
		recipe.AddIngredient(182, 10);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.Frostburn, 360, false);
	}
}
