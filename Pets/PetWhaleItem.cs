using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace ZooAbyss.Pets
{
    public class PetWhaleItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Musical Whale Microphone");
            // Names and descriptions of all ExamplePetX classes are defined using .hjson files in the Localization folder
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.ZephyrFish); // Copy the Defaults of the Zephyr Fish Item.

            Item.shoot = ModContent.ProjectileType<PetWhale>(); // "Shoot" your pet projectile.
            Item.buffType = ModContent.BuffType<PetWhaleBuff>(); // Apply buff upon usage of the Item.
            Item.shootSpeed = 16;
        }

        public override void UseStyle(Player player, Rectangle heldItemFrame)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(Item.buffType, 3600);
            }
        }
    }
}