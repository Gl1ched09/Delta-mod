using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using InstinctMod.content.items;

namespace InstinctMod.content.items.pickaxes;  
public class ExcavatorOfWorlds : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Excavator Of Worlds"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
        Tooltip.SetDefault("'A pickaxe so powerful that it is capeable of destroying worlds'");
    }

    public override void SetDefaults()
    {
        Item.damage = 8;
        Item.DamageType = DamageClass.Melee;
        Item.width = 28;
        Item.height = 28;
        Item.useTime = 18;
        Item.useAnimation = 18;
        Item.useStyle = 1;
        Item.knockBack = 2;
        Item.value = 10000;
        Item.rare = 3;
        Item.UseSound = SoundID.Item1;
        Item.autoReuse = true;
        Item.pick = 155;
        Item.useTurn = true;
        Item.scale = 1.3f;
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.DemoniteBar, 13);
        recipe.AddIngredient(ItemID.MoltenPickaxe, 1);
        recipe.AddIngredient(ModContent.ItemType<GalaxyiteBar>(), 12);
        recipe.AddTile(TileID.DemonAltar);
        recipe.Register();

        Recipe Recipe = CreateRecipe();
        Recipe.AddIngredient(ItemID.CrimtaneBar, 13);
        Recipe.AddIngredient(ItemID.MoltenPickaxe, 1);
        Recipe.AddIngredient(ModContent.ItemType<GalaxyiteBar>(), 12);
        Recipe.AddTile(TileID.DemonAltar);
        Recipe.Register();
    }
}
