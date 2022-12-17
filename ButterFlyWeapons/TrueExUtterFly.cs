using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbyss.Edits;
using ZooAbyss.ButterFlyWeaponsProj;

namespace ZooAbyss.ButterFlyWeapons
{
    public class TrueExUtterFly : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("True ExUtterfly");
            Tooltip.SetDefault("What is it doing down here?");
        }

        public override void SetDefaults()
        {
            Item.damage = 70;
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
            Item.rare = ItemRarityID.LightPurple;
            Item.value = Item.buyPrice(0, 2, 0, 0);
            Item.shoot = ModContent.ProjectileType<TrueExUtterFlyP>();
            Item.shootSpeed = 17;

        }
        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[Item.shoot] < 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<ExUtterFly>(), 1)
                .AddIngredient(ItemID.ChlorophyteBar, 20)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}