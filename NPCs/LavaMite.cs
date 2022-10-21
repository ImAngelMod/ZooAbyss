using IL.Terraria.GameContent.ItemDropRules;
using On.Terraria.GameContent.ItemDropRules;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;
using ZooAbis.Items;
using ItemDropRule = Terraria.GameContent.ItemDropRules.ItemDropRule;

namespace ZooAbis.NPCs
{
    public class LavaMite : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lava Mite");
            Main.npcFrameCount[NPC.type] = 2;
        }

        public override void SetDefaults()
        {
            NPC.width = 10;
            NPC.height = 8;
            NPC.damage = 0;
            NPC.defense = 0;
            NPC.lifeMax = 8;
            NPC.value = 10f;
            NPC.aiStyle = 7;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = new SoundStyle("ZooAbis/Sound/LavaMiteDeath");
            AIType = NPCID.CochinealBeetle;
            AnimationType = NPCID.CochinealBeetle;
            NPC.scale = 0.8f;
            NPC.catchItem = ModContent.ItemType<LavaMiteItem>();
            NPC.lavaImmune = true;
        }
        public override bool? CanBeCaughtBy(Item item, Player player)
        {
            return item.type == ItemID.FireproofBugNet;
        }
        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
           npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LavaLump>(),3));
        }



        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.Underworld.Chance * 0.20f;
        }
    }
}

