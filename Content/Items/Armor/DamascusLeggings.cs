using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Armor;

[AutoloadEquip(EquipType.Legs)]
public class DamascusLeggings : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 22;
		Item.height = 18;
		Item.value = Item.buyPrice(0, 1, 0, 0);
		Item.rare = ItemRarityID.Green;
		Item.defense = 4;
		Item.ResearchUnlockCount = 1;
	}

	public override void UpdateEquip(Player player)
	{
		player.moveSpeed += 0.06f;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(Mod, "DamascusBar", 15);
		recipe.AddIngredient(Mod, "SwordMatter", 65);
		recipe.AddTile(TileID.Anvils);
		recipe.Register();
	}
}
