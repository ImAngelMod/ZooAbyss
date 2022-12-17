using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbyss.Edits;
using ZooAbyss.ButterFlyWeaponsProj;

namespace ZooAbyss.ButterFlyWeapons
{
    public class GuterFly : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("GutterFly");
            Tooltip.SetDefault("A butterfly Infused With Red");
        }

        public override void SetDefaults()
        {
            Item.damage = 20;
            Item.knockBack = 2;
            Item.DamageType = ModContent.GetInstance<Flutter>();
            Item.noUseGraphic = true;
            Item.useTime = 10;
            Item.autoReuse = false;
            Item.UseSound = SoundID.Item1;
            Item.useAnimation = 10;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 1.5f;
            Item.height = 50;
            Item.rare = ItemRarityID.LightRed;
            Item.value = Item.buyPrice(0, 2, 0, 0);
            Item.shoot = ModContent.ProjectileType<GuterFlyP>();
            Item.shootSpeed = 15;
        }
        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[Item.shoot] < 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<RustyButterFly>(), 1)
                .AddIngredient(ItemID.TissueSample, 10)
                .AddIngredient(ItemID.CrimtaneBar, 5)
                .AddTile(TileID.DemonAltar)
                .Register();
        }
    }
}