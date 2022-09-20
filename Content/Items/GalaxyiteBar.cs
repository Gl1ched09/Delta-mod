using Terraria.ModLoader;
using Terraria.ID;

namespace InstinctMod.Content.Items
{
    internal class GalaxyiteBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Galaxyite Bar");
            Tooltip.SetDefault("'Looks like it came from another universe'");
        }

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 24;
            Item.value = 30000;
            Item.maxStack = 9999;
        }

        public override void AddRecipes()
        {
            var recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<GalaxyOre>(), 4);
            recipe.AddTile(TileID.Furnaces);
            recipe.Register();
        }
    }
}