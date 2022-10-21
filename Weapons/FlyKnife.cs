using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbis.Ammo;
using ZooAbis.projectiles;
using Microsoft.Xna.Framework;
using System;

namespace ZooAbis.Weapons
{
    public class FlyKnife : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("ButterFlyKnife");
            Tooltip.SetDefault("your average butterflyknife");
        }

        public override void SetDefaults()
        {
            Item.damage = 30;
            Item.knockBack = 2;
            Item.DamageType = DamageClass.Melee;
            Item.noUseGraphic = true;
            Item.useTime = 20;
            Item.autoReuse = true;
            Item.UseSound = SoundID.Item1;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 1.5f;
            Item.height = 50;
            Item.rare = ItemRarityID.Gray;
            Item.value = Item.buyPrice(0, 2, 0, 0);
            Item.shoot = ModContent.ProjectileType<FlyKnifeP>();
            Item.shootSpeed = 20;
        }
    }
}