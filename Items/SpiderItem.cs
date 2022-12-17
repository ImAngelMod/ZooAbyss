using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZooAbyss.Items
{
    public class SpiderItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spider");
            Tooltip.SetDefault("It emits a faint light");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.rare = ItemRarityID.Green;

            Item.maxStack = 99;
            Item.value = Item.buyPrice(silver: 15);

        }
    }
}
