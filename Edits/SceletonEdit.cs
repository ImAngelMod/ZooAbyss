using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;
using Terraria;
using Terraria.ID;
using ZooAbis.Weapons;
using ZooAbis.ButterFlyWeapons;

namespace ZooAbis.Edits
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