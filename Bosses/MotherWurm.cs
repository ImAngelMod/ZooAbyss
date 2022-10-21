using Microsoft.Xna.Framework;
using System.IO;
using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbis.Bosses;

namespace ZooAbis.Bosses
{
    // These three class showcase usage of the WormHead, WormBody and WormTail classes from Worm.cs
    internal class MotherWurmHead : WormHead
    {
        public override int BodyType => ModContent.NPCType<MotherWurmBody>();

        public override int TailType => ModContent.NPCType<MotherWurmTail>();

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mother Wurm");
            NPC.BossBar = ModContent.GetInstance<MotherWurmBossBar>();
            
            /*var drawModifier = new NPCID.Sets.NPCBestiaryDrawModifiers(0)
            { // Influences how the NPC looks in the Bestiary
                CustomTexturePath = "ExampleMod/Content/NPCs/ExampleWorm_Bestiary", // If the NPC is multiple parts like a worm, a custom texture for the Bestiary is encouraged.
                Position = new Vector2(40f, 24f),
                PortraitPositionXOverride = 0f,
                PortraitPositionYOverride = 12f
            };
            NPCID.Sets.NPCBestiaryDrawOffset.Add(NPC.type, drawModifier);*/
        }

        public override void SetDefaults()
        {
            NPC.BossBar = ModContent.GetInstance<MotherWurmBossBar>();
            NPC.CloneDefaults(NPCID.DiggerHead);
            NPC.aiStyle = 6;
            NPC.lifeMax = 3000;
            NPC.damage = 50;
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            // We can use AddRange instead of calling Add multiple times in order to add multiple items at once
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[] {
				// Sets the spawning conditions of this NPC that is listed in the bestiary.
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Underground,
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Caverns,

				// Sets the description of this NPC that is listed in the bestiary.
				new FlavorTextBestiaryInfoElement("MAMA.")
            });
        }

        public override void Init()
        {
            // Set the segment variance
            // If you want the segment length to be constant, set these two properties to the same value
            MinSegmentLength = 100;
            MaxSegmentLength = 100;
           
            CommonWormInit(this);
        }

        // This method is invoked from ExampleWormHead, ExampleWormBody and ExampleWormTail
        internal static void CommonWormInit(Worm worm)
        {
            // These two properties handle the movement of the worm
            worm.MoveSpeed = 40f;
            worm.Acceleration = 0.2f;
        }

        private int attackCounter;
        public override void SendExtraAI(BinaryWriter writer)
        {
            writer.Write(attackCounter);
        }

        public override void ReceiveExtraAI(BinaryReader reader)
        {
            attackCounter = reader.ReadInt32();
        }

    }
    

    internal class MotherWurmBody : WormBody
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mother Wurm");

            /*NPCID.Sets.NPCBestiaryDrawModifiers value = new NPCID.Sets.NPCBestiaryDrawModifiers(0)
            {
                Hide = true // Hides this NPC from the Bestiary, useful for multi-part NPCs whom you only want one entry.
            };
            NPCID.Sets.NPCBestiaryDrawOffset.Add(NPC.type, value);*/
        }

        public override void SetDefaults()
        {
            NPC.CloneDefaults(NPCID.DiggerBody);
            NPC.aiStyle = 6;
        }

        public override void Init()
        {
            MotherWurmHead.CommonWormInit(this);
        }
    }

    internal class MotherWurmTail : WormTail
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mother Wurm");

            /*NPCID.Sets.NPCBestiaryDrawModifiers value = new NPCID.Sets.NPCBestiaryDrawModifiers(0)
            {
                Hide = true // Hides this NPC from the Bestiary, useful for multi-part NPCs whom you only want one entry.
            };
            NPCID.Sets.NPCBestiaryDrawOffset.Add(NPC.type, value);*/
        }

        public override void SetDefaults()
        {
            NPC.CloneDefaults(NPCID.DiggerTail);
            NPC.aiStyle = 6;
        }

        public override void Init()
        {
            MotherWurmHead.CommonWormInit(this);
        }
    }
}