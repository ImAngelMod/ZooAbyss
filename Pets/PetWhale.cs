using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZooAbyss.Pets
{
    public class PetWhale : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[Projectile.type] = 4;
            Main.projPet[Projectile.type] = true;
        }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.ZephyrFish); // Copy the stats of the Zephyr Fish

            AIType = ProjectileID.ZephyrFish; // Copy the AI of the Zephyr Fish.
            
            
        }

        public override bool PreAI()
        {
            Player player = Main.player[Projectile.owner];

            player.zephyrfish = false; // Relic from aiType

            return true;
        }

        public override void AI()
        {
            Player player = Main.player[Projectile.owner];

            Projectile.velocity.X = 1;
            Projectile.velocity.Y = 1;
            Projectile.velocity.X = -1;
            Projectile.velocity.Y = -1;

            // Keep the projectile from disappearing as long as the player isn't dead and has the pet buff.
            if (!player.dead && player.HasBuff(ModContent.BuffType<PetWhaleBuff>()))
            {
                Projectile.timeLeft = 2;
                
            }
        }
    }
}