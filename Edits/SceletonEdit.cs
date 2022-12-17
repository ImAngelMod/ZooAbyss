using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbyss.ButterFlyWeapons;
using ZooAbyss.Weapons;

namespace ZooAbyss.Edits
{
    public class SceletonEdit : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.netID == NPCID.AngryBones)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BoneButterFly>(), 100));
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FlyKnife>(), 200));
            }
        }
    }
}