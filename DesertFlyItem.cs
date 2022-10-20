using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace ZooAbis.Items
{
    public class DesertFlyItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("DesertFly");
            Tooltip.SetDefault("BuzZ BuzZ..");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.rare = ItemRarityID.Yellow;
            Item.scale = 1;
            Item.maxStack = 99;
            Item.value = Item.buyPrice(silver: 15);

        }
    }
}
