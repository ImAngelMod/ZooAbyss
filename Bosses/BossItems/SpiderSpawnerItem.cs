using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbyss.Bosses;
using ZooAbyss.Bosses.BossMinionsAndAtk;
using ZooAbyss.Tiles;

namespace ZooAbyss.Bosses.BossItems
{
    public class SpiderSpawnerItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("SpiderSpawnerItem");
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
            Item.createTile = ModContent.TileType<SpiderSpawner>();
            Item.width = 12;
            Item.height = 12;
            Item.rare = 8;
        }
    }
}
