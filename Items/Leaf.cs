using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbis.Tiles;

namespace ZooAbis.Items
{
    public class Leaf : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Leaf");
            SacrificeTotal = 10;
        }
        public override void AddRecipes()
        {
            CreateRecipe(3)
                .AddIngredient(ItemID.Wood, 5)
                .AddTile(TileID.LivingLoom)
                .Register();
        }
    }
}

