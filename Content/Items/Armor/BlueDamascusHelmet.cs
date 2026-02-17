using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Armor;

[AutoloadEquip(EquipType.Head)]
public class BlueDamascusHelmet : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 16;
		Item.height = 18;
		Item.value = Item.buyPrice(0, 7, 0, 0);
		Item.rare = ItemRarityID.Cyan;
		Item.defense = 30;
		Item.ResearchUnlockCount = 1;
	}

	public override void UpdateEquip(Player player)
	{
		player.GetAttackSpeed(DamageClass.Melee) += 0.06f;
		player.GetCritChance(DamageClass.Generic) += 6f;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "DamascusBar", 15);
		recipe.AddIngredient(Mod, "DamascusHelmet", 1);
		recipe.AddIngredient(ItemID.SoulofMight, 15);
		recipe.AddIngredient(ItemID.SoulofSight, 15);
		recipe.AddIngredient(ItemID.SoulofFright, 15);
		recipe.AddIngredient(ItemID.IronskinPotion, 15);
		recipe.AddIngredient(ItemID.HallowedMask, 1);
		recipe.AddIngredient(ItemID.HallowedBar, 16);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}
}
