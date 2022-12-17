using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;
using ZooAbyss.Items;

namespace ZooAbyss.NPCs
{
    public class Spider : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spider");
            Main.npcFrameCount[NPC.type] = 4;

        }

        public override void SetDefaults()
        {
            NPC.width = 13;
            NPC.height = 8;
            NPC.damage = 0;
            NPC.defense = 0;
            NPC.lifeMax = 8;
            NPC.value = 10f;
            NPC.aiStyle = 67;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            AIType = NPCID.MagmaSnail;
            AnimationType = NPCID.MagmaSnail;
            NPC.scale = 0.7f;
            Main.npcCatchable[NPC.type] = true;
            NPC.catchItem = ModContent.ItemType<SpiderItem>();
        }
        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<SpiderVenom>(),2,2,3));
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.Cavern.Chance * 0.20f;
        }
    }
}