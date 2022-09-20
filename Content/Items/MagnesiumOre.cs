﻿using Terraria.ModLoader;

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
        }
    }
}