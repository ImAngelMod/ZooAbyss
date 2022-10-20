using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;
using ZooAbis.Tiles;

namespace ZooAbis.Items
{
    public class BottleOfSpiderVenom : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bottle Of Spider Venom");
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
                .AddIngredient(ModContent.ItemType<SpiderVenom>(), 10)
                .AddIngredient(ItemID.Bottle)
                .Register();
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<SpiderItem>())
                .AddIngredient(ItemID.Bottle)
                .AddTile(TileID.MythrilAnvil)
                .Register();
            CreateRecipe(1)
               .AddIngredient(ItemID.Bottle)
               .AddTile(ModContent.TileType<SpiderCageTile>())
               .Register();
        }
    }
}
