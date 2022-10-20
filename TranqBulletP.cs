using Terraria;
using System;
using Terraria.ID;
using Terraria.ModLoader;
using IL.Terraria.GameContent;
using Microsoft.Xna.Framework;

namespace ZooAbis.projectiles
{
    public class TranqBulletP : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("TranqBullet");
        }

        public override void SetDefaults()
        {
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.width = 8;
            Projectile.height = 8;
            Projectile.aiStyle = 0;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.penetrate = 1;
            Projectile.timeLeft = 600;
            Projectile.light = 0;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;
        }
        
    
        public override void AI()
        {
            int dust = Dust.NewDust(Projectile.Center, 1, 1, DustID.GemRuby, 0f, 0f, 0, (Color.Red), 1f);
            Main.dust[dust].noGravity = true;
            Main.dust[dust].velocity *= 0.3f;
            Main.dust[dust].scale = (float)Main.rand.Next(100, 135) * 0.013f;

            int dust2 = Dust.NewDust(Projectile.Center, 1, 1, DustID.Mothron, 0f, 0f, 0, (Color.LimeGreen), 1f);
            Main.dust[dust2].noGravity = true;
            Main.dust[dust2].velocity *= 0.3f;
            Main.dust[dust2].scale = (float)Main.rand.Next(50, 135) * 0.013f;
        }
    } 
}
