using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbis.Ammo;
using ZooAbis.projectiles;
using Microsoft.Xna.Framework;
using System;

namespace ZooAbis.Weapons
{
    public class EvilFlyKnife : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Evils Flying Knife");
            Tooltip.SetDefault("Its The Ying Yang Of Evil");
        }

        public override void SetDefaults()
        {
            Item.damage = 65;
            Item.knockBack = 2;
            Item.DamageType = DamageClass.Ranged;
            Item.noUseGraphic = true;
            Item.useTime = 145;
            Item.autoReuse = true;
            Item.UseSound = SoundID.Item1;
            Item.useAnimation = 145;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 1.5f;
            Item.height = 50;
            Item.rare = ItemRarityID.LightPurple;
            Item.value = Item.buyPrice(0, 2, 0, 0);
            Item.shoot = ModContent.ProjectileType<EvilFlyKnifeP>();
            Item.shootSpeed = 15;
        }
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<FlyKnife>(), 1)
                .AddIngredient(ItemID.LightKey, 1)
                .AddIngredient(ItemID.NightKey, 1)
                .AddIngredient(ItemID.SoulofFright, 20)
                .AddIngredient(ItemID.SoulofMight, 20)
                .AddIngredient(ItemID.SoulofSight, 20)
                .AddTile(TileID.MythrilAnvil)
                .Register();

        }
    }
}