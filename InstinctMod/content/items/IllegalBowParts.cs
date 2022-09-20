using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace InstinctMod.content.items
{
    internal class IllegalBowParts : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Illegal Bow Parts");
            Tooltip.SetDefault("");
        }
        public override void SetDefaults()
        {
            Item.width = 30;
                Item.height = 22;
            Item.value = Item.buyPrice(gold: 25);
            Item.maxStack = 1;
        }
    }
}
