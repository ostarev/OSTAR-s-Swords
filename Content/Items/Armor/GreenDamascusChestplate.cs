using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class GreenDamascusChestplate : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 20;
            Item.value = Item.sellPrice(0, 7, 0, 0);
            Item.rare = ItemRarityID.Green;
            Item.defense = 30;
        }

        public override void UpdateEquip(Player player)
        {
            player.GetAttackSpeed(DamageClass.Melee) += 0.1f;
            player.GetDamage(DamageClass.Melee) += 0.15f;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ModContent.ItemType<GreenDamascusHelmet>() &&
                   legs.type == ModContent.ItemType<GreenDamascusLeggings>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "25% increased melee speed, 7% increased melee critical chance, 50% increased movement speed, increases maximum life by 20";

            player.GetAttackSpeed(DamageClass.Melee) += 0.25f;
            player.GetCritChance(DamageClass.Generic) += 7f;
            player.moveSpeed += 0.50f;
            player.statLifeMax2 += 20;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(Mod, "DamascusBar", 15);
            recipe.AddIngredient(Mod, "DamascusBreastplate", 1);
            recipe.AddIngredient(ItemID.SoulofMight, 15);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(ItemID.SoulofFright, 15);
            recipe.AddIngredient(ItemID.SwiftnessPotion, 15);
            recipe.AddIngredient(ItemID.HallowedPlateMail, 1);
            recipe.AddIngredient(ItemID.HallowedBar, 16);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}