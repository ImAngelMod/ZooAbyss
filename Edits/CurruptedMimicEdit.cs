using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbyss.ButterFlyWeapons;

namespace ZooAbyss.Edits
{
    public class CurruptionMimicEdit : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.netID == NPCID.BigMimicCorruption)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<CursedButterFly>(), 5));
            }
        }
    }
}
