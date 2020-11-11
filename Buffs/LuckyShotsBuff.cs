using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UntoldLegends.Buffs
{
	public class LuckyShotsBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Lucky Shot");
			Description.SetDefault("10% Increased Damage");
			Main.debuff[Type] = false;
			Main.buffNoSave[Type] = true;
			canBeCleared = true;
		}
		public override void Update(Player player, ref int buffIndex)
		{
			player.allDamage += 0.10f;
		}
	}
}