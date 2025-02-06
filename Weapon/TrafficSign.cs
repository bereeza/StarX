using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using StarX.VisualEffects;

namespace StarX.Weapon {
    public class TrafficSign : ModItem {

        public override void SetDefaults() {
            Item.DamageType = DamageClass.Melee;
            Item.width = 96;
            Item.height = 96;
            Item.damage = 1;
            Item.knockBack = 45;
            Item.rare = ItemRarityID.Yellow;
            Item.value = Item.buyPrice(copper: 25);
            Item.maxStack = 1;
            Item.useStyle = ItemUseStyleID.Swing; 
            Item.useTime = 30;                    
            Item.useAnimation = 35;              
            Item.autoReuse = true;
        }

        public override void MeleeEffects(Player player, Rectangle hitbox) {
            if (Main.rand.NextBool(1)) {  
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, ModContent.DustType<Particle>());
            }
        }

        public override void AddRecipes() {
            CreateRecipe()
                .AddIngredient(ItemID.SilverBar, 15)
                .AddTile(TileID.SkyMill).Register();
        }
    }
}
