using Terraria.ModLoader;
using Terraria.ID;

namespace InstinctMod.Content.Items
{
    internal class GalaxyOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Galaxy Ore");
            Tooltip.SetDefault("'Looks like it came from another universe'");
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.value = 1000;
            Item.maxStack = 9999;
        }

        public override void AddRecipes()
        {
            var recipe = CreateRecipe(2);
            recipe.AddIngredient(ItemID.FallenStar, 1);
            recipe.AddIngredient(ItemID.Hellstone, 2);
            recipe.AddTile(TileID.Furnaces);
            recipe.Register();
        }
    }
}