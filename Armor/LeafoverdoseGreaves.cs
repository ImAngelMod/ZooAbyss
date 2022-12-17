using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbyss.Items;

namespace ZooAbyss.Armor
{
	// The AutoloadEquip attribute automatically attaches an equip texture to this item.
	// Providing the EquipType.Legs value here will result in TML expecting a X_Legs.png file to be placed next to the item's main texture.
	[AutoloadEquip(EquipType.Legs)]
	public class LeafoverdoseGreaves : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("LeafOverdoseGreaves");
			Tooltip.SetDefault("the bottems of natures."
				+ "\n5% increased movement speed");
	



			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 16; // Width of the item
			Item.height = 9; // Height of the item
			Item.value = Item.sellPrice(gold: 1); // How many coins the item is worth
			Item.rare = ItemRarityID.Green; // The rarity of the item
			Item.defense = 2; // The amount of defense the item will give when equipped
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.05f; // Increase the movement speed of the playerPaintID
			player.statDefense += 2;
		}

        // Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ItemID.Wood, 7)
                .AddIngredient(ModContent.ItemType<Leaf>(), 2)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}