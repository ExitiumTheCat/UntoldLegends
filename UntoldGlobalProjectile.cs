using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UntoldLegends
{
	public class UntoldGlobalProjectile : GlobalProjectile
	{
		public override void AI(Projectile projectile)
		{

			if (projectile.type == ProjectileID.WoodenArrowFriendly)
			{
				if (Main.LocalPlayer.GetModPlayer<UntoldPlayer>().SuperSharpenedArrows == true)
				{
					projectile.penetrate = 2;
				}
			}
		}
	}
}