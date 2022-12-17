using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;


namespace ZooAbyss.Items
{
    public class BottleOfCobraVenom : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bottle Of Cobra Venom");
            Tooltip.SetDefault("Its make you Sleepy");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 8;
            Item.height = 11;
            Item.rare = ItemRarityID.Purple;

            Item.maxStack = 10;
            Item.value = Item.buyPrice(silver: 50);
        }
              public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<CobraVenom>(), 10)
                .AddIngredient(ItemID.Bottle)
                .Register();
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<CobraItem>())
                .AddIngredient(ItemID.Bottle)
               .AddTile(TileID.MythrilAnvil)
                .Register();
           // CreateRecipe(1)
              // .AddIngredient(ItemID.Bottle)
              // .AddTile(ModContent.TileType<SpiderCageTile>())
               //.Register();
        }
    }
}
