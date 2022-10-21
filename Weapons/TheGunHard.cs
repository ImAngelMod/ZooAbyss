using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbis.Ammo;
using ZooAbis.projectiles;
using Microsoft.Xna.Framework;

namespace ZooAbis.Weapons
{
    public class TheGunHard : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Pistol Of The Jungle Destroyers");
            Tooltip.SetDefault("Use with a special type of ammo to down an animal");
        }

        public override void SetDefaults()
        {
            Item.damage = 20;
            Item.DamageType = DamageClass.Ranged;
            Item.useTime = 40;
            Item.useAnimation = 40;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 2;
            Item.value = 100000;
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item11;
            Item.autoReuse = false;

            Item.shoot = ModContent.ProjectileType<TranqBulletP>();
            Item.useAmmo = ModContent.ItemType<TranqBulletAmmo>();
            Item.shootSpeed = 20;

        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-2f, -1f);
        }
        
        
          
        


        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<TheGunPre>(), 1);
            recipe.AddIngredient(ItemID.SquirrelCage, 1);
            recipe.AddIngredient(ItemID.WaterStrider, 1);
            recipe.AddIngredient(ItemID.RifleScope, 1);
            recipe.AddIngredient(ItemID.Pearlwood, 30);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.Register();
        }
    }   
    
}