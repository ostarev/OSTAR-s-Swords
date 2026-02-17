using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class Brisingr : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 35;
		Item.height = 35;
		Item.scale = 1.7f;
		Item.rare = ItemRarityID.Pink;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 10;
		Item.useAnimation = 10;
		Item.damage = 67;
		Item.knockBack = 10f;
		Item.UseSound = SoundID.Item1;
		Item.value = 590000;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.Excalibur, 1);
		recipe.AddIngredient(ItemID.Sapphire, 1);
		recipe.AddIngredient(ItemID.MeteoriteBar, 10);
		recipe.AddIngredient(ItemID.SoulofLight, 10);
		recipe.AddIngredient(ItemID.SoulofMight, 5);
		recipe.AddTile(TileID.DemonAltar);
		recipe.Register();
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.OnFire, 360, false);
	}
}
