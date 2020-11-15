using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace UntoldLegends
{
	public class UntoldClientConfig : ModConfig
	{
        public override ConfigScope Mode => ConfigScope.ClientSide;

        public static UntoldClientConfig Instance;

        [DefaultValue(true)]
        [Label("Aerial Takeover Rotation Visual")]
        public bool AerialTakeoverRotationVisualConfig;
    }
}