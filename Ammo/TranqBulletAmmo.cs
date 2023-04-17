using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbyss.Items;
using ZooAbyss.projectiles;

namespace ZooAbyss.Ammo
{
    public class TranqBulletAmmo : ModItem
    {
        public override void SetStaticDefaults()
        {
            // Item Name, Flavor Text
            DisplayName.SetDefault("TranqBullet");
            Tooltip.SetDefault("infused Ball Of Cobra Venom Use Wisley");
            // Journey Mode sacrifice/research amount.
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 999;
        }

        public override void SetDefaults()
        {
            //Stats:
            //Display Stats
            Item.width = 7; 
            Item.height = 7; 
            Item.shoot = ModContent.ProjectileType<TranqBulletP>();
            //Combat Stats
            Item.damage = 8;
            Item.DamageType = DamageClass.Ranged;
            Item.knockBack = 1f; 
            //Noncombat Stats
            Item.value = Item.sellPrice(0, 1, 0, 0); 
            Item.rare = ItemRarityID.Green;
            Item.ammo = Item.type;
        }
        
        

        public override void AddRecipes()
        {
            //Recipies. (Removed indent, to match Dart)
            CreateRecipe(1)
                .AddIngredient(ItemID.SoulofLight, 1)
                .AddIngredient(ItemID.SoulofNight, 1)
                .AddIngredient(ModContent.ItemType<BottleOfCobraVenom>(), 10)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}