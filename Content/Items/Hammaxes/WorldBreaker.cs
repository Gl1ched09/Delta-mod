using Terraria.ID;
using Terraria.ModLoader;

namespace InstinctMod.Content.Items.Hammaxes;

public class WorldBreaker : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("World Breaker");
        Tooltip.SetDefault("'A hammaxe so powerful that it can break worlds'");
    }

    public override void SetDefaults()
    {
        Item.damage = 24;
        Item.DamageType = DamageClass.Melee;
        Item.width = 54;
        Item.height = 50;
        Item.useTime = 18;
        Item.useAnimation = 18;
        Item.useStyle = ItemUseStyleID.Swing;
        Item.knockBack = 4;
        Item.value = 10000;
        Item.rare = ItemRarityID.Orange;
        Item.UseSound = SoundID.Item1;
        Item.autoReuse = true;
        Item.axe = 20;
        Item.hammer = 120;
        Item.useTurn = true;
    }

    public override void AddRecipes()
    {
        var recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.DemoniteBar, 8);
        recipe.AddIngredient(ItemID.MoltenHamaxe);
        recipe.AddIngredient(ModContent.ItemType<GalaxyiteBar>(), 6);
        recipe.AddTile(TileID.DemonAltar);
        recipe.Register();

        recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.CrimtaneBar, 8);
        recipe.AddIngredient(ItemID.MoltenHamaxe);
        recipe.AddIngredient(ModContent.ItemType<GalaxyiteBar>(), 6);
        recipe.AddTile(TileID.DemonAltar);
        recipe.Register();
    }
}