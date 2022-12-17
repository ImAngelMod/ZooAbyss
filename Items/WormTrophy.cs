using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbyss.Tiles;

namespace ZooAbyss.Items
{
    public class WormTrophy : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("WurmTrophy");
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
            Item.createTile = ModContent.TileType<WormTrophyTile>();
            Item.width = 12;
            Item.height = 12;
            Item.rare = 8;
        }

       
    }
}
