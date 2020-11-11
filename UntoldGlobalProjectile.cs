using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UntoldLegends
{
	public class UntoldGlobalProjectile : GlobalProjectile
	{
		public override void SetDefaults(Projectile projectile)
		{
			if (projectile.type == ProjectileID.WoodenArrowFriendly)
			{
				if (Main.LocalPlayer.GetModPlayer<UntoldPlayer>().SuperSharpenedArrows == true)
				{
					projectile.penetrate = 2;
				}
			}
			if (projectile.type == ProjectileID.Bullet)
			{
				if (Main.LocalPlayer.GetModPlayer<UntoldPlayer>().ShadowBullets == true)
				{
					projectile.penetrate = 4;
				}
			}
		}
		public override void AI(Projectile projectile)
		{
			Dust shadowdust;
			Vector2 position = projectile.Center;
			shadowdust = Main.dust[Dust.NewDust(position, 10, 10, 54, 0f, 0f, 0, new Color(109, 0, 255), 1f)];
			shadowdust.noGravity = true;
			shadowdust.noLight = true;
			shadowdust.fadeIn = 1.421053f;
		}
	}
}