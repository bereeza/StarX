using Terraria.Audio;
using Terraria.ModLoader;

namespace StarX.SoundEffects {
    public class ModSounds : ModSystem {
        public static readonly SoundStyle Swing = new SoundStyle("StarX/SoundEffects/Swing") {
            Volume = 1.0f,          
            PitchVariance = 0.2f   
        };
    }
}
