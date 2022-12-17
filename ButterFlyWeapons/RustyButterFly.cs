using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbyss.Edits;
using ZooAbyss.ButterFlyWeaponsProj;

namespace ZooAbyss.ButterFlyWeapons
{
    public class RustyButterFly : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("RustyButterFly");
            Tooltip.SetDefault("Actually prettysharp");
        }

        public override void SetDefaults()
        {
            Item.damage = 10;
            Item.knockBack = 2;
            Item.DamageType = ModContent.GetInstance<Flutter>();
            Item.noUseGraphic = true;
            Item.autoReuse = false;
            Item.UseSound = SoundID.Item1;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 1.5f;
            Item.rare = ItemRarityID.Gray;
            Item.value = Item.buyPrice(0, 2, 0, 0);
            Item.shoot = ModContent.ProjectileType<RustyButterFlyP>();
            Item.shootSpeed = 12;
            Item.useAnimation = 10;
            Item.useTime = 10;
        }
        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[Item.shoot] < 1;
        }
    }
}
