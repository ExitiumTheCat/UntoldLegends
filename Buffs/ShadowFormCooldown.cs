using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UntoldLegends.Buffs
{
	public class ShadowFormCooldown : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Shadow Form Cooldown");
			Description.SetDefault("Your shadow is regaining its power");
			Main.debuff[Type] = true;
			Main.buffNoSave[Type] = true;
			canBeCleared = false;
		}
	}
}