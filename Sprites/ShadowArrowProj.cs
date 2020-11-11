using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UntoldLegends.Sprites
{
	public class ShadowArrowProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shadow Arrow");
		}

		public override void SetDefaults()
		{
			projectile.arrow = true;
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.timeLeft = 1200;
			projectile.arrow = true;
			aiType = ProjectileID.WoodenArrowFriendly;
			projectile.penetrate = 4;
		}
		public override void AI()
		{
			projectile.rotation = projectile.velocity.ToRotation() + MathHelper.PiOver2;
			Dust shadowdust;
			Vector2 position = projectile.Center;
			shadowdust = Main.dust[Dust.NewDust(position, 10, 10, 54, 0f, 0f, 0, new Color(109, 0, 255), 1f)];
			shadowdust.noGravity = true;
			shadowdust.noLight = true;
			shadowdust.fadeIn = 1.421053f;
		}
	}
}