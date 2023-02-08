using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;


namespace ZooAbyss.NPCs
{
    public class GreenBeetle : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[NPC.type] = 4;
            Main.npcCatchable[NPC.type] = true;
            NPCID.Sets.CountsAsCritter[NPC.type] = true;
        }

        public override void SetDefaults()
        {
            NPC.CloneDefaults(NPCID.Snail);
            NPC.width = 30;
            NPC.height = 30;
            NPC.scale = 0.25f;
            NPC.damage = 0;
            NPC.defense = 0;
            NPC.npcSlots = 0.5f;
            AIType = NPCID.Snail;
            AnimationType = NPCID.Snail;
            NPC.lifeMax = 10;
            NPC.value = 0;
            NPC.chaseable = false;


        }

        public override void AI()
        {
            NPC.scale = 1f;
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldDay.Chance * 0.5f;
        }
    }
}