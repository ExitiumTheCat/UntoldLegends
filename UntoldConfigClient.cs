using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace UntoldLegends
{
    public class UntoldConfigClient : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        public static UntoldConfigClient Instance;

        [DefaultValue(true)]
        [Label("Balance Changes")]
        [Tooltip("Makes the player weaker to balance out with the Skill Trees")]
        public bool BalanceChanges;
    }
}