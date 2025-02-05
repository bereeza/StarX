using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace StarX.WeaponEffects {
    public class Sparkle : ModDust {
        public override void OnSpawn(Dust dust) {
            dust.velocity *= 0.6f;  
            dust.noGravity = false; 
            dust.scale *= 2.0f;  
        }

        // Оновлення частки
        public override bool Update(Dust dust) { 
            dust.position += dust.velocity;  
            dust.rotation += dust.velocity.X * 0.2f;  
            dust.scale *= 0.98f;  

            float light = 0.5f * dust.scale; 
            Lighting.AddLight(dust.position, light, light, light);  

            if (dust.scale < 1f) {
                dust.active = false;
            }

            return false;  
        }
    }
}
