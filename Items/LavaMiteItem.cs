using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZooAbyss.Items
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
