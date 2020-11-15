using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UntoldLegends
{
	public class DebugMaxSkillPointsItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Debug Max Skill Points Item");
		}

		public override void SetDefaults()
		{
			item.noMelee = true;
			item.useStyle = 4;
			item.useTime = 25;
			item.useAnimation = 25;
			item.width = 32;
			item.height = 32;
		}
		public override bool UseItem(Player player)
		{
			Main.LocalPlayer.GetModPlayer<UntoldPlayer>().SkillPoints += 1;
			return true;
		}
	}
}