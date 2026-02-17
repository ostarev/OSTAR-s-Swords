using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class Narsil : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 60;
		Item.height = 60;
		Item.scale = 1.3f;
		Item.rare = 8;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 13;
		Item.useAnimation = 13;
		Item.damage = 99;
		Item.knockBack = 7f;
		Item.UseSound = SoundID.Item1;
		Item.value = 130000;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "Sting", 1);
		recipe.AddIngredient(Mod, "Glamdring", 1);
		recipe.AddIngredient(Mod, "Orcrist", 1);
		recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(72, 360, false);
		target.AddBuff(BuffID.Ichor, 360, false);
		target.AddBuff(BuffID.OnFire, 360, false);
	}
}
