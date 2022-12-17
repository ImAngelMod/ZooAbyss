using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbyss.ButterFlyWeapons;

namespace ZooAbyss.Edits
{
    public class CrimsonMimicEdit : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.netID == NPCID.BigMimicCrimson)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<WeakingButterFly>(), 5));
            }
        }
    }
}
