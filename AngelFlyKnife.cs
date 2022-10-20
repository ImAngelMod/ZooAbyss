using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbis.Ammo;
using ZooAbis.projectiles;
using Microsoft.Xna.Framework;
using System;
using ZooAbis.Items;

namespace ZooAbis.Weapons
{
    public class AngelFlyKnife : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Angel's Butterfly Knife");
            Tooltip.SetDefault("Will return to it's rightful owner");
        }

        public override void SetDefaults()
        {
            Item.damage = 140;
            Item.knockBack = 2;
            Item.DamageType = DamageClass.Melee;
            Item.noUseGraphic = true;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.UseSound = SoundID.Item1;
            Item.useAnimation = 10;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 1.5f;
            Item.height = 50;
            Item.rare = ItemRarityID.Pink;
            Item.value = Item.buyPrice(0, 2, 0, 0);
            Item.shoot = ModContent.ProjectileType<AngelFlyKnifeP>();
            Item.shootSpeed = 16;
            
        }
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ItemID.LunarBar, 10)
                .AddIngredient(ModContent.ItemType<EvilFlyKnife>(), 1)
                .AddIngredient(ItemID.FragmentSolar, 5)
                .AddIngredient(ItemID.RichMahogany, 15)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }
}