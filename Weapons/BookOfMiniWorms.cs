using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbyss.projectiles;


namespace ZooAbyss.Weapons
{
    public class BookOfMiniWorms : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("BookOfMiniWorms");
            Tooltip.SetDefault("Will return to it's rightful owner");
        }

        public override void SetDefaults()
        {
            Item.damage = 20;
            Item.knockBack = 2;
            Item.DamageType = DamageClass.Magic;
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
            Item.shoot = ModContent.ProjectileType<BookOfMiniWormsP>();
            Item.shootSpeed = 10;

        }
    }
}