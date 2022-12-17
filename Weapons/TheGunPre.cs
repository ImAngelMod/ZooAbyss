using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbyss.Ammo;
using ZooAbyss.projectiles;
using SoundStyle = Terraria.Audio.SoundStyle;

namespace ZooAbyss.Weapons
{
	public class TheGunPre : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("TheRifle Of The JungleSleepers");
			Tooltip.SetDefault("use With A special ammo to down a animal.");
		}

		public override void SetDefaults()
		{
			Item.damage = 12;
			Item.DamageType = DamageClass.Ranged;
			Item.useTime = 150;
			Item.useAnimation = 150;
			Item.knockBack = 2;
			Item.value = 10000;
			Item.rare = ItemRarityID.Green;
			Item.UseSound = SoundID.Item11;
			Item.autoReuse = false;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.shoot = ModContent.ProjectileType<TranqDartP>();
			Item.useAmmo = ModContent.ItemType<TranqDartAmmo>();
			Item.shootSpeed = 12;
            Item.UseSound = new SoundStyle("ZooAbyss/Sound/TheGunPreFireSound");

        }
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-13f, -0f);
		}
		


        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Musket, 1);
			recipe.AddIngredient(ItemID.Vine, 10);
			recipe.AddIngredient(ItemID.Stinger, 12);
			recipe.AddIngredient(ItemID.RichMahogany, 30);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}