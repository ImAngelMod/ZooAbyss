using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace ZooAbyss.SummitProj
{
    public class SummitPFerra4: ModProjectile

    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("wItH a BuTtErFlY");
        }
        public int ProjDelay = 10; // frames remaining till we can fire a projectile again
        public int ProjDamage = 250; // frames remaining till we can fire a projectile again
        public override void SetDefaults()
        {
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.width = 32;
            Projectile.height = 32;
            Projectile.friendly = true;
            Projectile.penetrate = -1;
            Projectile.aiStyle = 18;
            Projectile.timeLeft = 10;
            AIType = 23;
            Projectile.damage = 200;
            Projectile.tileCollide = false;


        }

        public override void AI()
        {
            int dust = Dust.NewDust(Projectile.Center, 1, 1, DustID.GrassBlades, 0f, 0f, 0, (Color.LimeGreen), 1f);
            Main.dust[dust].noGravity = true;
            Main.dust[dust].velocity *= 0.3f;
            Main.dust[dust].scale = (float)Main.rand.Next(50, 135) * 0.012f;

            int dust2 = Dust.NewDust(Projectile.Center, 1, 1, DustID.PinkTorch, 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust2].noGravity = true;
            Main.dust[dust2].velocity *= 0.3f;
            Main.dust[dust2].scale = (float)Main.rand.Next(50, 135) * 0.012f;


            Player owner = Main.player[Projectile.owner]; // Get the owner of the projectile.
            if (Main.myPlayer == Projectile.owner)
            {
                if (ProjDelay > 0)
                {
                    ProjDelay--;
                }
                if (ProjDelay <= 1)
                {
                    Projectile.NewProjectile(Projectile.GetSource_FromThis(null), Projectile.Center, Projectile.velocity * +1, ModContent.ProjectileType<SummitPKing5>(), ProjDamage, 1f, Main.myPlayer, -1, -1);
                    ProjDelay = 5;
                }

            }
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {

            target.AddBuff(BuffID.Venom, 300);

        }
    }
}































