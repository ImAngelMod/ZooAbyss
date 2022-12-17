using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbyss.Edits;
using ZooAbyss.ButterFlyWeaponsProj;

namespace ZooAbyss.ButterFlyWeapons
{
    public class TerraButterFly : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Terra Butterfly");
            Tooltip.SetDefault("What is it doing down here?");
        }

        public override void SetDefaults()
        {
            Item.damage = 100;
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
            Item.rare = ItemRarityID.Green;
            Item.value = Item.buyPrice(0, 2, 0, 0);
            Item.shoot = ModContent.ProjectileType<TerraButterFlyP>();
            Item.shootSpeed = 17;

        }
        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[Item.shoot] < 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<TrueNightsButterFly>(), 1)
                .AddIngredient(ModContent.ItemType<TrueExUtterFly>(), 1)
                .AddIngredient(ItemID.BrokenHeroSword, 1)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}