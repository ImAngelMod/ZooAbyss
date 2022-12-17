using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbyss.ButterFlyWeapons;

namespace ZooAbyss.Edits
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
