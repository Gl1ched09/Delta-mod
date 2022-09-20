using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace InstinctMod.content.items
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
        }
    }
}
