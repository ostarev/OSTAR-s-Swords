using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Armor;

[AutoloadEquip(EquipType.Body)]
public class DamascusBreastplate : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 26;
		Item.height = 20;
		Item.value = Item.buyPrice(0, 2, 0, 0);
		Item.rare = ItemRarityID.Green;
		Item.defense = 6;
		Item.ResearchUnlockCount = 1;
	}

	public override bool IsArmorSet(Item head, Item body, Item legs)
	{
		return head.type == Mod.Find<ModItem>("DamascusHelmet").Type &&
		       legs.type == Mod.Find<ModItem>("DamascusLeggings").Type;
	}

	public override void UpdateArmorSet(Player player)
	{
		player.setBonus = "4 extra defense, 4% increased melee damage, 3% increased melee speed, 4% increased melee critical chance";
		player.GetDamage(DamageClass.Melee) += 0.04f;
		player.statDefense += 4;
		player.GetAttackSpeed(DamageClass.Melee) += 0.03f;
		player.GetCritChance(DamageClass.Melee) += 4f;
	}

	public override void UpdateEquip(Player player)
	{
		player.GetDamage(DamageClass.Melee) += 0.04f;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "DamascusBar", 20);
		recipe.AddIngredient(Mod, "SwordMatter", 60);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
	}
}
