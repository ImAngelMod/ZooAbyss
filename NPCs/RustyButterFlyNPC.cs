using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;
using ZooAbyss.ButterFlyWeapons;

namespace ZooAbyss.NPCs
{
    public class RustyButterFlyNPC : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[NPC.type] = 8;
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
            AIType = NPCID.Butterfly;
            AnimationType = NPCID.Firefly;
            NPC.lifeMax = 10;
            NPC.value = 0;
            NPC.chaseable = false;
            

        }

        public override void AI()
        {
            NPC.scale = 1f;
            NPC.catchItem = ModContent.ItemType<RustyButterFly>();
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldDay.Chance * 0.2f;
        }
    }
}