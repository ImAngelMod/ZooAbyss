using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbyss.Edits;
using ZooAbyss.ButterFlyWeaponsProj;

namespace ZooAbyss.ButterFlyWeapons
{
    public class TrueNightsButterFly : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("True Eclipse Butterfly");
            Tooltip.SetDefault("What is it doing down here?");
        }

        public override void SetDefaults()
        {
            Item.damage = 10;
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
            Item.rare = ItemRarityID.Purple;
            Item.value = Item.buyPrice(0, 2, 0, 0);
            Item.shoot = ModContent.ProjectileType<TrueNightsButterFlyP>();
            Item.shootSpeed = 17;

        }
        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[Item.shoot] < 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<NightsButterFly>(), 1)
                .AddIngredient(ItemID.SoulofFright, 20)
                .AddIngredient(ItemID.SoulofMight, 20)
                .AddIngredient(ItemID.SoulofSight, 20)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}