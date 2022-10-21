using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using ZooAbis.Armor;
using ZooAbis.ButterFlyWeapons;
using Zooabis.Edits;
using ZooAbis.Items;

namespace ZooAbis.Armor
{
    // The AutoloadEquip attribute automatically attaches an equip texture to this item.
    // Providing the EquipType.Head value here will result in TML expecting a X_Head.png file to be placed next to the item's main texture.
    [AutoloadEquip(EquipType.Head)]
    public class LeafoverdoseHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("LeafOverdoseMask");
            Tooltip.SetDefault("Get Your Head in the Trees.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 3;

            // If your head equipment should draw hair while drawn, use one of the following:
            // ArmorIDs.Head.Sets.DrawHead[Item.headSlot] = false; // Don't draw the head at all. Used by Space Creature Mask
            // ArmorIDs.Head.Sets.DrawHatHair[Item.headSlot] = true; // Draw hair as if a hat was covering the top. Used by Wizards Hat
            // ArmorIDs.Head.Sets.DrawFullHair[Item.headSlot] = true; // Draw all hair as normal. Used by Mime Mask, Sunglasses
            // ArmorIDs.Head.Sets.DrawBackHair[Item.headSlot] = true;
            // ArmorIDs.Head.Sets.DrawsBackHairWithoutHeadgear[Item.headSlot] = true; 
        }

        public override void SetDefaults()
        {
            Item.width = 18; // Width of the item
            Item.height = 18; // Height of the item
            Item.value = Item.sellPrice(gold: 1); // How many coins the item is worth
            Item.rare = ItemRarityID.Green; // The rarity of the item
            Item.defense = 2; // The amount of defense the item will give when equipped
        }

        // IsArmorSet determines what armor pieces are needed for the setbonus to take effect
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<LeafletChestplate>() && legs.type == ModContent.ItemType<LeafoverdoseGreaves>();
        }

        // UpdateArmorSet allows you to give set bonuses to the armor.
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Increases Fauna dealt damage by 5%"; // This is the setbonus tooltip
            player.GetDamage<Flutter>() += 0.05f;
            player.moveSpeed += 0.1f;
        }
        public override void UpdateEquip(Player player)
        {

            player.statDefense += 2;
        }

        // Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ItemID.Wood, 8)
                .AddIngredient(ModContent.ItemType<Leaf>(), 3)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}
