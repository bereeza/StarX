using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using StarX.VisualEffects;  

namespace StarX.Weapon {
    public class StarFinger : ModItem {

        public override void SetDefaults() {
            Item.DamageType = DamageClass.Melee;
            Item.width = 64;
            Item.height = 64;
            Item.damage = 9;
            Item.knockBack = 10;
            Item.rare = ItemRarityID.Gray;
            Item.value = Item.buyPrice(silver: 1);
            Item.maxStack = 1;
            Item.useStyle = ItemUseStyleID.Swing; 
            Item.useTime = 20;
            Item.useAnimation = 15;
            Item.crit = 6;
            Item.autoReuse = true;
        }

        public override void MeleeEffects(Player player, Rectangle hitbox) {
            if (Main.rand.NextBool(3)) {  
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, ModContent.DustType<Sparkle>());
            }
        }

        public override void AddRecipes() {
            CreateRecipe()
                .AddIngredient(ItemID.Star, 5)
                .AddIngredient(ItemID.Wood, 3)
                .AddTile(TileID.SkyMill)
                .Register();
        }
    }
}
