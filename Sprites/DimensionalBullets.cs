using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UntoldLegends.Sprites
{
	public class DimensionalBullets : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dimensional Bullet");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.timeLeft = 1200;
			projectile.arrow = true;
			aiType = ProjectileID.Bullet;
		}
		public override void AI()
		{
			projectile.rotation = projectile.velocity.ToRotation();
		}
	}
}