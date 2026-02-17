using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class OldMansBlade : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 32;
		Item.height = 32;
		Item.scale = 1.9f;
		Item.rare = ItemRarityID.Yellow;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 10;
		Item.useAnimation = 10;
		Item.damage = 87;
		Item.knockBack = 7f;
		Item.UseSound = SoundID.Item8;
		Item.shoot = ProjectileID.GoldenShowerFriendly;
		Item.shootSpeed = 10f;
		Item.value = 180500;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "AllWoodSword", 1);
		recipe.AddIngredient(ItemID.SpookyWood, 99);
		recipe.AddIngredient(ItemID.Pearlwood, 81);
		recipe.AddIngredient(Mod, "Orichalcon", 1);
		recipe.AddIngredient(Mod, "SwordMatter", 100);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.Ichor, 360, false);
	}
}
