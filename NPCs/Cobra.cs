using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;
using ZooAbyss.Items;

namespace ZooAbyss.NPCs
{
    public class Cobra : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cobra");
            Main.npcFrameCount[NPC.type] = 3;

        }

        public override void SetDefaults()
        {
            NPC.width = 137;
            NPC.height = 74;
            NPC.damage = 20;
            NPC.defense = 8;
            NPC.lifeMax = 100;
            NPC.value = 1000f;
            NPC.aiStyle = 3;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            AIType = NPCID.LarvaeAntlion;
            AnimationType = NPCID.Zombie;
            NPC.scale = 0.7f;
            
        }
        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<CobraVenom>()));
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldDayDesert.Chance * 0.60f;
        }
        public override void OnHitByProjectile(Projectile projectile, int damage, float knockback, bool crit)
        {
            Main.npcCatchable[NPC.type] = true;
            NPC.catchItem = ModContent.ItemType<CobraItem>();
            NPC.damage = 0;
            AIType = NPCID.BoundGoblin;
            NPC.aiStyle = 0;
            AnimationType = 0;
            NPC.velocity.Y = 0;
            NPC.velocity.X = 0;
            NPC.stepSpeed = 100;


        }
        
    }
}







