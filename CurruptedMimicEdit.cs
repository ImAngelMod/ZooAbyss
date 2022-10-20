using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;
using Terraria;
using Terraria.ID;
using ZooAbis.ButterFlyWeapons;

namespace ZooAbis.Edits
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
