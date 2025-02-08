using Terraria.Audio;
using Terraria.ModLoader;

namespace StarX.SoundEffects {
    public class ModSounds : ModSystem {
        public static readonly SoundStyle Swing = new SoundStyle("StarX/SoundEffects/Swing") {
            Volume = 1.0f,        
        };

        public static readonly SoundStyle Moan = new SoundStyle("StarX/SoundEffects/Moan") {
            Volume = 1.0f,        
        };
    }
}
