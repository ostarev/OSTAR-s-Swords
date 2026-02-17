using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace OSTARsSWORDS
{
    public class OSTARConfig : ModConfig
    {
        // This is the "Direct" instance tModLoader will use
        public static OSTARConfig Instance;

        public override ConfigScope Mode => ConfigScope.ClientSide;

        // Define your own toggle here
        [DefaultValue(true)]
        public bool UseDoubleTap { get; set; }
    }
}