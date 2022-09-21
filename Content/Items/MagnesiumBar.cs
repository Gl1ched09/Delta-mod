using Terraria.ModLoader;
using Terraria.ID;

namespace InstinctMod.Content.Items
{
    internal class MagnesiumBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magnesium Bar");
            Tooltip.SetDefault("'Very chemically active'");
        }

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 24;
            Item.value = 1200;
            Item.maxStack = 9999;
        }

        public override void AddRecipes()
        {
            var recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<MagnesiumOre>(), 4);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.Register();
        }
    }
}