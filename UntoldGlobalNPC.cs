using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UntoldLegends
{
	public class UntoldGlobalNPC : GlobalNPC
	{
		public override void ModifyHitByProjectile(NPC npc, Projectile projectile, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
		{
			if (Main.LocalPlayer.GetModPlayer<UntoldPlayer>().AchillesHeel == true && !npc.boss)
			{
				if (Main.rand.NextFloat() < .02f)
				{
					damage = npc.lifeMax * 5;
				}
			}
		}
		public override void ModifyHitByItem(NPC npc, Player player, Item item, ref int damage, ref float knockback, ref bool crit)
		{
			if (Main.LocalPlayer.GetModPlayer<UntoldPlayer>().AchillesHeel == true && !npc.boss)
			{
				if (Main.rand.NextFloat() < .02f)
				{
					damage = npc.lifeMax * 5;
				}
			}
		}
	}
}