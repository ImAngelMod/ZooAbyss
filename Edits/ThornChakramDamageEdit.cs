using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace ZooAbyss.Edits
{
    public class ThornChakramDamage : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.ThornChakram) item.damage = 30;
        }
    }
}






