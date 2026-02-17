using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Armor;

[AutoloadEquip(EquipType.Legs)]
public class BlueDamascusLeggings : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 22;
		Item.height = 18;
		Item.value = Item.buyPrice(0, 7, 0, 0);
	    Item.rare = ItemRarityID.Cyan;
		Item.defense = 20;
		Item.ResearchUnlockCount = 1;
	}

	public override void UpdateEquip(Player player)
	{
		player.moveSpeed += 0.05f;
		player.GetCritChance(DamageClass.Generic) += 6f;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "DamascusBar", 15);
		recipe.AddIngredient(Mod, "DamascusLeggings", 1);
		recipe.AddIngredient(ItemID.SoulofMight, 15);
		recipe.AddIngredient(ItemID.SoulofSight, 15);
		recipe.AddIngredient(ItemID.SoulofFright, 15);
		recipe.AddIngredient(ItemID.IronskinPotion, 15);
		recipe.AddIngredient(ItemID.HallowedGreaves, 1);
		recipe.AddIngredient(ItemID.HallowedBar, 16);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}
}
