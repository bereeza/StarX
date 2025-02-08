using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using StarX.SoundEffects;

namespace StarX.Weapon {
    public class TheMostDangerousThing : ModItem {

        public override void SetDefaults() {
            Item.width = 32;
            Item.height = 32;
            Item.rare = ItemRarityID.Yellow;
            Item.value = Item.buyPrice(platinum: 5);
            Item.maxStack = 999;
            Item.useTime = 20;   
            Item.useStyle = ItemUseStyleID.HoldUp;                  
            Item.useAnimation = 20;              
            Item.autoReuse = true;

            Item.UseSound = ModSounds.Moan;
        }
    }
}