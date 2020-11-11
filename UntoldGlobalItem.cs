using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UntoldLegends
{
	public class UntoldGlobalItem : GlobalItem
	{
		/*
		public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			UntoldPlayer untoldplayer = Main.LocalPlayer.GetModPlayer<UntoldPlayer>();

			if (untoldplayer.ShadowArrows && untoldplayer.ShadowFormActivated)
			{
				if (type == ProjectileID.WoodenArrowFriendly)
				{
					type = ModContent.ProjectileType<ShadowArrowProj>();
				}
			}
			else if (!untoldplayer.ShadowFormActivated && type == ModContent.ProjectileType<ShadowArrowProj>())
			{
				type = ProjectileID.WoodenArrowFriendly;
			}

			if (untoldplayer.ShadowBullets && untoldplayer.ShadowFormActivated)
			{
				if (type == ProjectileID.Bullet)
				{
					type = ModContent.ProjectileType<ShadowBulletProj>();
				}
			}
			else if (!untoldplayer.ShadowFormActivated && type == ModContent.ProjectileType<ShadowBulletProj>())
			{
				type = ProjectileID.Bullet;
			}
			return true;
		}
		*/
	}
}