using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbis.projectiles;
using ZooAbis.Items;

namespace ZooAbis.Ammo
{
     public class TranqBulletAmmo : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("infused Ball Of Cobra Venom Use Wisley");
            DisplayName.SetDefault("TranqBullet");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 999;
        }

        public override void SetDefaults()
        {
            Item.width = 7; 
            Item.height = 7; 
            Item.damage = 8;
            Item.DamageType = DamageClass.Ranged;
            Item.maxStack = 999; 
            Item.consumable = true; 
            Item.knockBack = 1f; 
            Item.value = Item.sellPrice(0, 1, 0, 0); 
            Item.rare = ItemRarityID.Green;
            Item.shoot = ModContent.ProjectileType<TranqBulletP>();
            Item.ammo = Item.type;
        }
        
        


        public override void AddRecipes()
        {
                 CreateRecipe(1)
                .AddIngredient(ItemID.SoulofLight, 1)
                .AddIngredient(ItemID.SoulofNight, 1)
                .AddIngredient(ModContent.ItemType<BottleOfCobraVenom>(), 10)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}