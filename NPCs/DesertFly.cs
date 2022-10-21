using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader.Utilities;
using ZooAbis.Items;
using ItemDropRule = Terraria.GameContent.ItemDropRules.ItemDropRule;

namespace ZooAbis.NPCs
{
    public class DesertFly : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[NPC.type] = 5;
            Main.npcCatchable[NPC.type] = true;
            NPCID.Sets.CountsAsCritter[NPC.type] = true;
        }

        public override void SetDefaults()
        {
            NPC.CloneDefaults(NPCID.Butterfly);
            NPC.width = 30;
            NPC.height = 30;
            NPC.scale = 0.25f;
            NPC.damage = 0;
            NPC.defense = 0;
            NPC.npcSlots = 0.5f;
            NPC.catchItem = ModContent.ItemType<DesertFlyItem>();
            AIType = NPCID.LadyBug;
            AnimationType = NPCID.Firefly;
            NPC.lifeMax = 10;
            NPC.value = 0;
            NPC.chaseable = false;
        }
       
        public override void AI()
        {
            NPC.scale = 0.5f;
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.DesertCave.Chance * 0.60f;
        }
    }
}