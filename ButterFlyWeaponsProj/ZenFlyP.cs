using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Zooabis.Edits;

namespace ZooAbis.ButterFlyWeaponsProj
{
    public class ZenFlyP : ModProjectile

    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("wItH a BuTtErFlY");
        }

        public int ProjDamage = 5; // frames remaining till we can fire a projectile again
        public override void SetDefaults()
        {
            Projectile.DamageType = ModContent.GetInstance<Flutter>();
            Projectile.width = 32;
            Projectile.height = 32;
            Projectile.friendly = true;
            Projectile.penetrate = -1;
            Projectile.aiStyle = 3;
            Projectile.timeLeft = 290;
            AIType = 52;
            Projectile.damage = 20;

        }

        public override void AI()
        {
            int dust = Dust.NewDust(Projectile.Center, 1, 1, DustID.TerraBlade, 0f, 0f, 0, default, 1f);
            Main.dust[dust].noGravity = true;
            Main.dust[dust].velocity *= 0.3f;
            Main.dust[dust].scale = Main.rand.Next(50, 135) * 0.012f;

            int dust2 = Dust.NewDust(Projectile.Center, 1, 1, DustID.Dirt, 0f, 0f, 0, default, 1f);
            Main.dust[dust2].noGravity = true;
            Main.dust[dust2].velocity *= 0.3f;
            Main.dust[dust2].scale = Main.rand.Next(50, 135) * 0.012f;

        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {

            {
                Player owner = Main.player[Projectile.owner]; // Get the owner of the projectile.
                if (Main.myPlayer == Projectile.owner)
                {

                    {

                        Projectile.NewProjectile(Projectile.GetSource_FromThis(null), Projectile.BottomRight, Projectile.velocity * +1, ModContent.ProjectileType<ZenFlyPProj>(), ProjDamage, 1f, Main.myPlayer, -1, -1);
                        Projectile.NewProjectile(Projectile.GetSource_FromThis(null), Projectile.Bottom, Projectile.velocity * +1, ModContent.ProjectileType<ZenFlyPProj>(), ProjDamage, 1f, Main.myPlayer, -1, -1);
                        Projectile.NewProjectile(Projectile.GetSource_FromThis(null), Projectile.BottomLeft, Projectile.velocity * +1, ModContent.ProjectileType<ZenFlyPProj>(), ProjDamage, 1f, Main.myPlayer, -1, -1);
                        Projectile.NewProjectile(Projectile.GetSource_FromThis(null), Projectile.Right, Projectile.velocity * +1, ModContent.ProjectileType<ZenFlyPProj>(), ProjDamage, 1f, Main.myPlayer, -1, -1);
                        Projectile.NewProjectile(Projectile.GetSource_FromThis(null), Projectile.Left, Projectile.velocity * +1, ModContent.ProjectileType<ZenFlyPProj>(), ProjDamage, 1f, Main.myPlayer, -1, -1);
                        Projectile.NewProjectile(Projectile.GetSource_FromThis(null), Projectile.Top, Projectile.velocity * +1, ModContent.ProjectileType<ZenFlyPProj>(), ProjDamage, 1f, Main.myPlayer, -1, -1);
                        Projectile.NewProjectile(Projectile.GetSource_FromThis(null), Projectile.TopLeft, Projectile.velocity * +1, ModContent.ProjectileType<ZenFlyPProj>(), ProjDamage, 1f, Main.myPlayer, -1, -1);
                        Projectile.NewProjectile(Projectile.GetSource_FromThis(null), Projectile.TopRight, Projectile.velocity * +1, ModContent.ProjectileType<ZenFlyPProj>(), ProjDamage, 1f, Main.myPlayer, -1, -1);
                    }
                }

            }
            return (true);
        }
    }
}


