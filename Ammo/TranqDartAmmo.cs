using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbyss.Items;
using ZooAbyss.projectiles;

namespace ZooAbyss.Ammo
{
    public class TranqDartAmmo : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Sleepy Sleepy time animals");
            DisplayName.SetDefault("TranqDart");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 999;
        }

        public override void SetDefaults()
        {
            Item.width = 7; 
            Item.height = 12; 
            Item.damage = 8;
            Item.DamageType = DamageClass.Ranged;
            Item.maxStack = 999; 
            Item.consumable = true; 
            Item.knockBack = 1f; 
            Item.value = Item.sellPrice(0, 0, 50, 0); 
            Item.rare = ItemRarityID.Green;
            Item.shoot = ModContent.ProjectileType<TranqDartP>(); 
            Item.ammo = Item.type; 
        }



        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ItemID.Stinger, 1)
                .AddIngredient(ModContent.ItemType<BottleOfSpiderVenom>(), 10)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}