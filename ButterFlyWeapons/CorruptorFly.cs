﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbyss.Edits;
using ZooAbyss.ButterFlyWeaponsProj;

namespace ZooAbyss.ButterFlyWeapons
{
    public class CorruptorFly : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eather Of ButterFlies");
            Tooltip.SetDefault("A Butterfly Of PurePurple");
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
            Item.rare = ItemRarityID.Purple;
            Item.value = Item.buyPrice(0, 2, 0, 0);
            Item.shoot = ModContent.ProjectileType<CorruptorFlyP>();
            Item.shootSpeed = 15;
        }
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ItemID.ShadowScale, 10)
                .AddIngredient(ModContent.ItemType<RustyButterFly>(), 1)
                .AddIngredient(ItemID.DemoniteBar, 5)
                .AddTile(TileID.DemonAltar)
                .Register();
        }
        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[Item.shoot] < 1;
        }
    }
}