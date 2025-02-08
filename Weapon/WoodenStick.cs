using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StarX.Weapon {
    public class WoodenStick : ModItem {

        public override void SetDefaults() {
            Item.DamageType = DamageClass.Melee;
            Item.width = 32;
            Item.height = 32;
            Item.damage = 5;
            Item.knockBack = 5;
            Item.rare = ItemRarityID.Gray;
            Item.value = Item.buyPrice(copper: 25);
            Item.maxStack = 99;
            Item.useStyle = ItemUseStyleID.Swing; 
            Item.useTime = 20;                    
            Item.useAnimation = 20;              
            Item.autoReuse = true;

            Item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes() {
            CreateRecipe().
                AddIngredient(ItemID.Wood, 15).
                AddTile(TileID.SkyMill).Register();
        }
    }
}