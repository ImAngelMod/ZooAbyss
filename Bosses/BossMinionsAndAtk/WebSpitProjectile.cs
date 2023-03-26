using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZooAbyss.Bosses.BossMinionsAndAtk
{
    public class WebSpitProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 16;
            Projectile.height = 16;
            Projectile.aiStyle = 1;
            Projectile.friendly = true;
            Projectile.penetrate = 1;
            Projectile.timeLeft = 600; // adjust this as needed
            AIType = ProjectileID.WoodenArrowHostile;
            Projectile.scale = 0.25f;
        }

        public override void AI()
        {
            if (Projectile.timeLeft % 60 == 0)
            {
                Player player = Main.player[Projectile.owner];
                if (Projectile.Distance(player.Center) < 50f)
                {
                    player.AddBuff(BuffID.Webbed, 120); // adjust the duration as needed
                }
            }
        }

        public override void Kill(int timeLeft)
        {
            int cobwebX = (int)(Projectile.Center.X / 4f);
            int cobwebY = (int)(Projectile.Center.Y / 4f);

            // Check if the tile at the cobweb location is solid before placing the cobweb
            Tile tile = Framing.GetTileSafely(cobwebX, cobwebY);
            if (!tile.HasTile)
            {
                WorldGen.PlaceTile(cobwebX, cobwebY, TileID.Cobweb, true);
            }
          
        }
    }
}
