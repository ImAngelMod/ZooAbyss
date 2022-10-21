using Terraria;
using System;
using Terraria.ID;
using Terraria.ModLoader;
using IL.Terraria.GameContent;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using ZooAbis.NPCs;
using Terraria.Audio;
using Humanizer;

namespace ZooAbis.projectiles
{
    public class TerraFormerP : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Terraformer");
        }

        public override void SetDefaults()
        {
            Projectile.netImportant = true;
            //Projectile.CloneDefaults(ProjectileID.DD2OgreSmash);
            Projectile.aiStyle = 1;
            AIType = 52;
            Projectile.width = 32;
            Projectile.height = 32;
            Projectile.damage = 350;
            Projectile.tileCollide = true;
            Projectile.friendly = true;
            Projectile.ownerHitCheck = true;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.hostile = false;
            Projectile.penetrate = -1;
            Projectile.timeLeft = 100;
            Projectile.timeLeft = 500;



        }



        public override void AI()
        {
            int dust = Dust.NewDust(Projectile.Center, 1, 1, DustID.Grass, 0f, 0f, 0, default, 1f);
            Main.dust[dust].noGravity = true;
            Main.dust[dust].velocity *= 0.3f;
            Main.dust[dust].scale = Main.rand.Next(100, 135) * 0.013f;

            int dust2 = Dust.NewDust(Projectile.Center, 1, 1, DustID.Dirt, 0f, 0f, 0, default, 1f);
            Main.dust[dust2].noGravity = true;
            Main.dust[dust2].velocity *= 0.3f;
            Main.dust[dust2].scale = Main.rand.Next(50, 135) * 0.013f;
        }
        public override void Kill(int timeLeft)
        {
            Vector2 launchVelocity = new Vector2(-4, 0);
            for (int i = 0; i < 4; i++)
            {
                launchVelocity = launchVelocity.RotatedBy(MathHelper.PiOver4);
            }

        }

        // Now, using CloneDefaults() and aiType doesn't copy EVERY aspect of the projectile. In Vanilla, several other methods
        // are used to generate different effects that aren't included in AI. For the case of the Meowmete projectile, since the
        // richochet sound is not included in the AI, we must add it ourselves:
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            int index = Projectile.NewProjectile(Projectile.GetSource_FromThis(null), Projectile.Center, Vector2.Zero, ProjectileID.DD2OgreSmash, 340, Projectile.knockBack, Projectile.owner, 0.0f, (float)(0.850000023841858 + (double)Main.rand.NextFloat() * 1.14999997615814));
            Main.projectile[index].DamageType = DamageClass.Melee;
            Main.projectile[index].hostile = false;
            Main.projectile[index].friendly = true;
            Main.projectile[index].penetrate = 15;
            // Since there are two Richochet sounds for the Meowmere, we can randomly choose between them like this:

            SoundEngine.PlaySound(Main.rand.NextBool() ? SoundID.DD2_OgreGroundPound : SoundID.DD2_MonkStaffGroundImpact, Projectile.position);

            // Essentially, using ? and : is a glorified and shortened method of creating a simple if statement in
            // a single line. If Main.rand.NextBool() reurns true, it plays SoundID.Item57. If it returns false, then it
            // will play SoundID.Item58. The condition goes before the ? and the two possibilities follow, separated by a :

            // This line calls the base (empty) implementation of this hook method to return its default value, which in its case is always 'true'.
            // Hover on the method below in VS to see its summary.
            return base.OnTileCollide(oldVelocity);
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.immune[Projectile.owner] = 6;
            OnHitEffects(target.Center, crit);
        }

        public override void OnHitPvp(Player target, int damage, bool crit)
        {
            OnHitEffects(target.Center, crit);
        }
        private void OnHitEffects(Vector2 targetPos, bool crit)
        {
            int index = Projectile.NewProjectile(Projectile.GetSource_FromThis(null), Projectile.Center, Vector2.Zero, ProjectileID.DD2OgreSmash, 100, Projectile.knockBack, Projectile.owner, 0.0f, (float)(0.850000023841858 + (double)Main.rand.NextFloat() * 1.14999997615814));
            Main.projectile[index].DamageType = DamageClass.Melee;
            SoundEngine.PlaySound(Main.rand.NextBool() ? SoundID.DD2_OgreGroundPound : SoundID.DD2_MonkStaffGroundImpact, Projectile.position);
            Main.projectile[index].hostile = false;
            Main.projectile[index].friendly = true;
            Main.projectile[index].penetrate = 15;

        }

    }
}

