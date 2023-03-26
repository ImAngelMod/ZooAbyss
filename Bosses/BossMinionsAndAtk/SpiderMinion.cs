using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZooAbyss.Bosses.BossMinionsAndAtk
{
    public class SpiderMinion : ModNPC
    {
        
        private bool jumping = false;
        private int jumpTimer = 0;
        private const int MAX_JUMP_TIME = 60;
        private int jumpDelay = 5 * 60; // 5 seconds in frames

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spider Minion");
        }

        public override void SetDefaults()
        {
            NPC.width = 32;
            NPC.height = 32;
            NPC.damage = 20;
            NPC.defense = 10;
            NPC.lifeMax = 100;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.value = Item.buyPrice(0, 0, 5, 0);
            NPC.knockBackResist = 1f;
            NPC.aiStyle = -1; // This NPC uses a custom AI
            AIType = -1;
            NPC.scale = 0.25f;
            NPC.noGravity = false; // The spider minion doesn't need gravity since it moves on the ground
        }

        public override void AI()
        {
            NPC.TargetClosest(true);

            if (NPC.target < 0 || NPC.target == 255 || Main.player[NPC.target].dead || Vector2.Distance(NPC.Center, Main.player[NPC.target].Center) > 1000f)
            {
                // If the target is invalid or too far away, stop moving
                NPC.velocity = Vector2.Zero;
                return;
            }

            // Calculate the direction towards the target
            Vector2 targetDirection = Vector2.Normalize(Main.player[NPC.target].Center - NPC.Center);

            // Check if the NPC is on the ground
            bool onGround = NPC.collideY;

            // Decide whether to jump or move towards the target
            if (onGround)
            {
                // The NPC is on the ground, check if it should jump
                if (Vector2.Distance(NPC.Center, Main.player[NPC.target].Center) < 500f && jumpTimer >= jumpDelay)
                {
                    // Jump towards the target
                    NPC.velocity.Y = -10f;
                    jumping = true;
                    jumpTimer = 0;

                    // Debug message
                    Main.NewText("Spider minion jumped!");
                }
                else
                {
                    // Move towards the target
                    NPC.velocity = targetDirection;

                    // Update the jump timer
                    if (jumping)
                    {
                        jumpTimer++;

                        if (jumpTimer >= MAX_JUMP_TIME)
                        {
                            jumping = false;
                        }
                    }
                    else if (jumpTimer < jumpDelay)
                    {
                        jumpTimer++;
                    }
                }
            }
            else
            {
                // The NPC is in the air, apply gravity
                NPC.noGravity = false;
            }

            // Spawn cobwebs around the NPC
            if (Main.rand.NextBool(100))
            {
                int cobwebX = (int)(NPC.Center.X / 16f);
                int cobwebY = (int)(NPC.Center.Y / 16f);

                // Check if the tile at the cobweb location is solid before placing the cobweb
                Tile tile = Framing.GetTileSafely(cobwebX, cobwebY);
                if (!tile.HasTile)
                {
                    WorldGen.PlaceTile(cobwebX, cobwebY, TileID.Cobweb, true);
                }
            }
        }
    }
}