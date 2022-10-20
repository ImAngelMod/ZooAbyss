using Terraria;
using System;
using Terraria.ID;
using Terraria.ModLoader;
using IL.Terraria.GameContent;
using Microsoft.Xna.Framework;

namespace ZooAbis.projectiles
{
    public class EvilFlyKnifeP : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Angel's Wrath");
        }

        public override void SetDefaults()
        {
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.width = 32;
            Projectile.height = 32;
            Projectile.friendly = true;
            Projectile.penetrate = - 1;
            Projectile.aiStyle = 3;
            Projectile.timeLeft = 290;
            AIType = 52;
            Projectile.damage = 65;
        }

        public override void AI()
        {
            int dust = Dust.NewDust(Projectile.Center, 1, 1, DustID.t_Flesh, 0f, 0f, 0, (Color.Red), 1f);
            Main.dust[dust].noGravity = true;
            Main.dust[dust].velocity *= 0.3f;
            Main.dust[dust].scale = (float)Main.rand.Next(100, 135) * 0.013f;

            int dust2 = Dust.NewDust(Projectile.Center, 1, 1, DustID.VilePowder, 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust2].noGravity = true;
            Main.dust[dust2].velocity *= 0.3f;
            Main.dust[dust2].scale = (float)Main.rand.Next(50, 135) * 0.013f;
        }
    } 
}
