using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using InstinctMod.content.items;

namespace InstinctMod.content.items.hammaxes;
public class WorldBreaker : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("World Breaker"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
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
        Item.useStyle = 1;
        Item.knockBack = 4;
        Item.value = 10000;
        Item.rare = 3;
        Item.UseSound = SoundID.Item1;
        Item.autoReuse = true;
        Item.axe = 20;
        Item.hammer = 120;
        Item.useTurn = true;
       
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.DemoniteBar, 8);
        recipe.AddIngredient(ItemID.MoltenHamaxe, 1);
        recipe.AddIngredient(ModContent.ItemType<GalaxyiteBar>(), 6);
        recipe.AddTile(TileID.DemonAltar);
        recipe.Register();

        Recipe Recipe = CreateRecipe();
        Recipe.AddIngredient(ItemID.CrimtaneBar, 8);
        Recipe.AddIngredient(ItemID.MoltenHamaxe, 1);
        Recipe.AddIngredient(ModContent.ItemType<GalaxyiteBar>(), 6);
        Recipe.AddTile(TileID.DemonAltar);
        Recipe.Register();
    }
}

