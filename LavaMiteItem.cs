using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace ZooAbis.Items
{
    public class LavaMiteItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lava Mite");
            Tooltip.SetDefault("It's warm and jiggly");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.rare = ItemRarityID.Orange;

            Item.maxStack = 99;
            Item.value = Item.buyPrice(silver: 15);

        }
    }
}
