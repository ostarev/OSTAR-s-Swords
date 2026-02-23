using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items
{
    internal class Grease : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.maxStack = 999;
            Item.value = 66;
            Item.rare = ItemRarityID.Green;
            Item.ResearchUnlockCount = 25;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(12);
            recipe.AddIngredient(ItemID.Burger, 1);
            recipe.Register();

            Recipe recipe2 = CreateRecipe(10);
            recipe2.AddIngredient(ItemID.Pizza, 1);
            recipe2.Register();

            Recipe recipe3 = CreateRecipe(4);
            recipe3.AddIngredient(ItemID.CookedFish, 1);
            recipe3.Register();

            Recipe recipe4 = CreateRecipe(6);
            recipe4.AddIngredient(ItemID.Shrimp, 1);
            recipe4.Register();

            Recipe recipe5 = CreateRecipe(6);
            recipe5.AddRecipeGroup(RecipeGroupID.Squirrels, 1);
            recipe5.Register();

            Recipe recipe6 = CreateRecipe(1);
            recipe6.AddRecipeGroup(RecipeGroupID.Snails, 1);
            recipe6.Register();

            Recipe recipe7 = CreateRecipe(1);
            recipe7.AddRecipeGroup(RecipeGroupID.Fireflies, 1);
            recipe7.Register();

            Recipe recipe8 = CreateRecipe(1);
            recipe8.AddRecipeGroup(RecipeGroupID.Bugs, 1);
            recipe8.Register();

            Recipe recipe9 = CreateRecipe(1);
            recipe9.AddRecipeGroup(RecipeGroupID.Dragonflies, 1);
            recipe9.Register();

            Recipe recipe10 = CreateRecipe(5);
            recipe10.AddRecipeGroup(RecipeGroupID.Turtles, 1);
            recipe10.Register();

            Recipe recipe11 = CreateRecipe(1);
            recipe11.AddRecipeGroup(RecipeGroupID.Birds, 2);
            recipe11.Register();
        }
    }
}
