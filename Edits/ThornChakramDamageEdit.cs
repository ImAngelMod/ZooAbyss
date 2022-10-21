using Terraria.ID;
using Terraria;
using Terraria.ModLoader;


namespace ZooAbis.Edits
{
    public class ThornChakramDamage : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.ThornChakram) item.damage = 30;
        }
    }
}






