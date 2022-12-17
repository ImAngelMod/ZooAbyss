using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbyss.ButterFlyWeapons;

namespace ZooAbyss.Edits
{

    public class KingSlime : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.KingSlime)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KingButterFly>(), 2));
            }
        }
    }
}
    