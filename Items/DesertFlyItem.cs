using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZooAbyss.Items
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
