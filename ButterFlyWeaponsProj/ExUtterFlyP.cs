using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZooAbyss.Edits;

namespace ZooAbyss.ButterFlyWeaponsProj
{
    public class ExUtterFlyP : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("wItH a BuTtErFlY");
        }

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

        }

        public override void AI()
        {
            int dust = Dust.NewDust(Projectile.Center, 1, 1, DustID.HallowedTorch, 0f, 0f, 0, default, 1f);
            Main.dust[dust].noGravity = true;
            Main.dust[dust].velocity *= 0.3f;
            Main.dust[dust].scale = Main.rand.Next(50, 135) * 0.012f;

            int dust2 = Dust.NewDust(Projectile.Center, 1, 1, DustID.HallowedPlants, 0f, 0f, 0, default, 1f);
            Main.dust[dust2].noGravity = true;
            Main.dust[dust2].velocity *= 0.3f;
            Main.dust[dust2].scale = Main.rand.Next(50, 135) * 0.012f;

        }

    }
}




