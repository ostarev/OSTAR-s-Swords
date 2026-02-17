using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Armor;

[AutoloadEquip(EquipType.Body)]
public class BlueDamascusChestplate : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 26;
		Item.height = 20;
		Item.value = Item.buyPrice(0, 7, 0, 0);
		Item.rare = ItemRarityID.Cyan;
		Item.defense = 20;
		Item.ResearchUnlockCount = 1;
	}

	public override bool IsArmorSet(Item head, Item body, Item legs)
	{
		if (head.type == Mod.Find<ModItem>("BlueDamascusHelmet").Type)
		{
			return legs.type == Mod.Find<ModItem>("BlueDamascusLeggings").Type;
		}
		return false;
	}

	public override void UpdateArmorSet(Player player)
	{
		player.setBonus = "10% endurance, 7% increased melee critical chance, increases maximum life by 60";
		player.endurance += 0.1f;
		player.GetCritChance(DamageClass.Generic) += 7f;
		player.statLifeMax2 += 60;
	}

	public override void UpdateEquip(Player player)
	{
		ref StatModifier damage = ref player.GetDamage(DamageClass.Melee);
		damage += 0.07f;
		player.moveSpeed += 0.1f;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "DamascusBar", 15);
		recipe.AddIngredient(Mod, "DamascusBreastplate", 1);
		recipe.AddIngredient(ItemID.SoulofMight, 15);
		recipe.AddIngredient(ItemID.SoulofSight, 15);
		recipe.AddIngredient(ItemID.SoulofFright, 15);
		recipe.AddIngredient(ItemID.IronskinPotion, 15);
		recipe.AddIngredient(ItemID.HallowedPlateMail, 1);
		recipe.AddIngredient(ItemID.HallowedBar, 16);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}
}
