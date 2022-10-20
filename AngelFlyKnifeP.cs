using Terraria;
using System;
using Terraria.ID;
using Terraria.ModLoader;
using IL.Terraria.GameContent;
using Microsoft.Xna.Framework;

namespace ZooAbis.projectiles
{
    public class AngelFlyKnifeP : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Angel's Wrath");
        }

        public override void SetDefaults()
        {
            Projectile.DamageType = DamageClass.Melee;
            Projectile.width = 24;
            Projectile.height = 26;
            Projectile.friendly = true;
            Projectile.penetrate = -1;
            Projectile.aiStyle = 3;
            Projectile.timeLeft = 290;
            AIType = 52;
            Projectile.damage = 200;
            Projectile.tileCollide = false;

        }

        public override void AI()
        {
            int dust = Dust.NewDust(Projectile.Center, 1, 1, DustID.PinkTorch, 0f, 0f, 0, (Color.Pink), 1f);
            Main.dust[dust].noGravity = true;
            Main.dust[dust].velocity *= 0.3f;
            Main.dust[dust].scale = (float)Main.rand.Next(100, 135) * 0.013f;

            int dust2 = Dust.NewDust(Projectile.Center, 1, 1, DustID.Grubby, 0f, 0f, 0, (Color.MediumPurple), 1f);
            Main.dust[dust2].noGravity = true;
            Main.dust[dust2].velocity *= 0.3f;
            Main.dust[dust2].scale = (float)Main.rand.Next(50, 135) * 0.013f;
        }
    } 
}
