using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class SwordOfTheEmperor : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 35;
		Item.height = 35;
		Item.scale = 1.9f;
		Item.rare = ItemRarityID.Red;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 11;
		Item.useAnimation = 11;
		Item.damage = 100;
		Item.knockBack = 3f;
		Item.UseSound = SoundID.Item74;
		Item.value = 999999;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "SwordMatter", 4000);
		recipe.AddIngredient(ItemID.HallowedBar, 4000);
		recipe.AddIngredient(ItemID.BrokenHeroSword, 16);
		recipe.AddIngredient(ItemID.EnchantedSword, 4);
		recipe.AddIngredient(ItemID.Terragrim, 1);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(Mod.Find<ModBuff>("EmperorBlazeBuff").Type, 999, true);
	}

	public override void OnHitPvp(Player player, Player target, Player.HurtInfo hurtInfo)
	{
		target.AddBuff(Mod.Find<ModBuff>("EmperorBlazeBuff").Type, 999, true, false);
	}
}
