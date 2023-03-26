using Terraria.ModLoader;
using Terraria.ID;


namespace ZooAbyss.Bosses.BossItems
{
    public class WormMusicBoxItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Music Box");
            Tooltip.SetDefault("Plays a tune when activated");
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = 1;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<WormMusicBoxTile>();
            Item.value = 5;
        }
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ItemID.Wood, 10)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}
