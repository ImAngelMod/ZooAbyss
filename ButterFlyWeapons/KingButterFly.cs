using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbyss.Edits;
using ZooAbyss.ButterFlyWeaponsProj;

namespace ZooAbyss.ButterFlyWeapons
{
    public class KingButterFly : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("KingButterFly");
            Tooltip.SetDefault("Its the King Of butterflies But not the King of ButterFlies");
        }

        public override void SetDefaults()
        {
            Item.damage = 16;
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
            Item.rare = ItemRarityID.Blue;
            Item.value = Item.buyPrice(0, 2, 0, 0);
            Item.shoot = ModContent.ProjectileType<KingButterFlyP>();
            Item.shootSpeed = 15;
        }
        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[Item.shoot] < 1;
        }
    }
}