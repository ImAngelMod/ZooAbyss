using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace ZooAbis.Items
{
    public class LavaLump: ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lave Lump");
            Tooltip.SetDefault("A little Warm lump");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 8;
            Item.height = 11;
            Item.rare = ItemRarityID.Orange;

            Item.maxStack = 10;
            Item.value = Item.buyPrice(silver: 50);

        }
    }
}
