using Terraria.ID;
using Terraria;
using Terraria.ModLoader;


namespace ZooAbis.Edits
{
    public class ThornChakram : ModSystem
    {
        public override void AddRecipes()
        {
            Recipe recipe = Recipe.Create(ItemID.ThornChakram);
            recipe.AddIngredient(ItemID.BeeWax, 5);
            recipe.AddIngredient(ItemID.Vine, 8);
            recipe.AddIngredient(ItemID.Stinger, 9);
            recipe.Register();
        }
        public override void PostAddRecipes()
        {
            for (int i = 0; i < Recipe.numRecipes; i++)
            {
                Recipe recipe = Main.recipe[i];

                if (recipe.HasResult(ItemID.ThornChakram))
                {
                    recipe.DisableRecipe();
                    break;
                }

            }

        }
    }
}