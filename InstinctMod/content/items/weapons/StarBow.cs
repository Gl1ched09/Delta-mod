using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace InstinctMod.content.items.weapons
{
    public class StarBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Star Bow"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("'So, you picked this over a cannon.'");
        }

        public override void SetDefaults()
        {
            Item.damage = 61;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 13;
            Item.useAnimation = 13;
            Item.useStyle = 5;
            Item.knockBack = 0;
            Item.value = 20000;
            Item.rare = 2;
            Item.autoReuse = true;
            Item.shoot = 955;
            Item.useAmmo = AmmoID.FallenStar;
            Item.shootSpeed = 20f;
            Item.crit = 12;
            Item.noMelee = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.FallenStar, 10);
            recipe.AddIngredient(ItemID.MeteoriteBar, 10);
            recipe.AddIngredient(ModContent.ItemType<SmallSharkBow>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }

        public override Vector2? HoldoutOffset()
        {

            Vector2 offset = new Vector2(2, 0);
            return offset;

        }
    }
}
        

       