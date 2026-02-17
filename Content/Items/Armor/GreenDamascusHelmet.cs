using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class GreenDamascusHelmet : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = Item.sellPrice(0, 7, 0, 0);
            Item.rare = ItemRarityID.Green;
            Item.defense = 20;
        }

        public override void UpdateEquip(Player player)
        {
            player.GetAttackSpeed(DamageClass.Melee) += 0.20f;
            player.GetCritChance(DamageClass.Generic) += 14f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(Mod, "DamascusBar", 15);
            recipe.AddIngredient(Mod, "DamascusHelmet", 1);
            recipe.AddIngredient(ItemID.SoulofMight, 15);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(ItemID.SoulofFright, 15);
            recipe.AddIngredient(ItemID.SwiftnessPotion, 15);
            recipe.AddIngredient(ItemID.HallowedMask, 1);
            recipe.AddIngredient(ItemID.HallowedBar, 16);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}