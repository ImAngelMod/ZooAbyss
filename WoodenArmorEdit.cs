using Terraria.ID;
using Terraria;
using Terraria.ModLoader;


namespace ZooAbis.Edits
{
    public class WoodenArmorEdit: GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.WoodBreastplate)
            {
                if (item.type == ItemID.WoodenBoomerang) item.damage =+ 200;
            }
            if (item.type == ItemID.WoodGreaves)
            {

            }
            if (item.type == ItemID.WoodHelmet)
            {

            }
        }
    }
}






