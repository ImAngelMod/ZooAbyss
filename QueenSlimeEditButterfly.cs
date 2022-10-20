using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;
using Terraria;
using Terraria.ID;
using ZooAbis.ButterFlyWeapons;

namespace ZooAbis.Edits
{
    public class QueenSlime : GlobalNPC
        {
            public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
            {
                if (npc.netID == NPCID.QueenSlimeBoss) 
                    {
                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<HallowedButterFly>(), 2));
                }
            }
        }
    }
