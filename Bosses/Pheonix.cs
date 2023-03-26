using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZooAbyss.Bosses
{
    public class Pheonix : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pheonix");


        }

        public override void SetDefaults()
        {
            NPC.width = 137;
            NPC.height = 74;
            NPC.damage = 20;
            NPC.defense = 8;
            NPC.lifeMax = 10000;
            NPC.value = 1000f;
            NPC.aiStyle = 0;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            AIType = NPCID.LarvaeAntlion;
            AnimationType = NPCID.Zombie;
            NPC.scale = 0.7f;
            NPC.boss = true;
            NPC.noGravity = true;
            NPC.knockBackResist = -1;

            if (!Main.dedServ)
            {
                Music = MusicLoader.GetMusicSlot(Mod, "Sound/Music/Scorching_Catalyst");

            }
        }
        public override void AI()
        {
            if (NPC.life <= NPC.lifeMax / 2) // If health is half or less
            {
                NPC.aiStyle = 1; // Change AI style to flying
                NPC.velocity.Y = -10; // Change velocity to fly up
            }
        }

    }
    
}