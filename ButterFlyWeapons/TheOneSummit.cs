using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbyss.Edits;
using ZooAbyss.SummitProj;

namespace ZooAbyss.ButterFlyWeapons
{
    public class TheOneSummit : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("TheOneSummit");
            Tooltip.SetDefault("What is it doing down here?");
        }

        public override void SetDefaults()
        {
            Item.damage = 500;
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
            Item.rare = ItemRarityID.Expert;
            Item.value = Item.buyPrice(0, 2, 0, 0);
            Item.shoot = ModContent.ProjectileType<SummitP>();
            Item.shootSpeed = 5;
            Item.autoReuse = true;

        }
        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[Item.shoot] < 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<BuzzerFly>(), 1)
                .AddIngredient(ModContent.ItemType<CursedButterFly>(), 1)
                .AddIngredient(ModContent.ItemType<PlantFerra>(), 1)
                .AddIngredient(ModContent.ItemType<TerraButterFly>(), 1)
                .AddIngredient(ModContent.ItemType<KingButterFly>(), 1)
                .AddIngredient(ModContent.ItemType<HallowedButterFly>(), 1)
                .AddIngredient(ItemID.Bananarang, 10)
                .AddIngredient(ItemID.FlyingKnife, 1)
                .AddIngredient(ItemID.CombatWrench, 1)
                .AddIngredient(ItemID.PossessedHatchet, 1)
                .AddIngredient(ItemID.PaladinsHammer, 1)
                .AddIngredient(ItemID.IceBoomerang, 1)
                .AddIngredient(ItemID.LightDisc, 5)
                .AddIngredient(ItemID.Shroomerang, 1)
                .AddTile(TileID.LunarCraftingStation)
                .Register();

            CreateRecipe(1)
             .AddIngredient(ModContent.ItemType<BuzzerFly>(), 1)
             .AddIngredient(ModContent.ItemType<WeakingButterFly>(), 1)
             .AddIngredient(ModContent.ItemType<PlantFerra>(), 1)
             .AddIngredient(ModContent.ItemType<TerraButterFly>(), 1)
             .AddIngredient(ModContent.ItemType<KingButterFly>(), 1)
             .AddIngredient(ModContent.ItemType<HallowedButterFly>(), 1)
             .AddIngredient(ItemID.Bananarang, 10)
             .AddIngredient(ItemID.FlyingKnife, 1)
             .AddIngredient(ItemID.CombatWrench, 1)
             .AddIngredient(ItemID.PossessedHatchet, 1)
             .AddIngredient(ItemID.PaladinsHammer, 1)
             .AddIngredient(ItemID.IceBoomerang, 1)
             .AddIngredient(ItemID.LightDisc, 5)
             .AddTile(TileID.LunarCraftingStation)
             .Register();
        }
    }
}