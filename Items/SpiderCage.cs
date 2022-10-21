using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbis.Tiles;

namespace ZooAbis.Items
{
    public class SpiderCage : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spider Cage");
            SacrificeTotal = 1;
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.maxStack = 99;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<SpiderCageTile>();
            Item.width = 12;
            Item.height = 12;
            Item.rare = 8; 
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(1);
            recipe.AddIngredient((ItemID.Terrarium), 1);
            recipe.AddIngredient(ModContent.ItemType<SpiderItem>(), 1);
            recipe.Register();
        }
    }
}