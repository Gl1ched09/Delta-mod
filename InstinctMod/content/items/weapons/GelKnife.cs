using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace InstinctMod.content.items.weapons
{
    public class GelKnife : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("GelKnife"); 
            Tooltip.SetDefault("'Made from the flesh of dead slimes.'");
        }

        public override void SetDefaults()
        {
            Item.damage = 14;
            Item.DamageType = DamageClass.Melee;
            Item.width = 38;
            Item.height = 36;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = 1;
            Item.knockBack = 10;
            Item.value = 100;
            Item.rare = 1;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Gel, 12);
            recipe.AddIngredient(ItemID.PinkGel, 4);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}