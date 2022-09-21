using Terraria.ID;
using Terraria.ModLoader;

namespace InstinctMod.Content.Items
{
    internal class MagnesiumOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magnesium Ore");
            Tooltip.SetDefault("'Very chemically active'");
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.value = 500;
            Item.maxStack = 9999;
            Item.consumable = true;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useAnimation = 10;
            Item.useTime = 1;
            Item.autoReuse = true;
            Item.createTile = ModContent.TileType<Content.Tiles.MagnesiumOre>();
        }
    }
}