using Terraria.ID;
using Terraria.ModLoader;

namespace InstinctMod.Content.Items.Pickaxes;

public class ExcavatorOfWorlds : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Excavator Of Worlds");
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
        Item.useStyle = ItemUseStyleID.Swing;
        Item.knockBack = 2;
        Item.value = 10000;
        Item.rare = ItemRarityID.Orange;
        Item.UseSound = SoundID.Item1;
        Item.autoReuse = true;
        Item.pick = 155;
        Item.useTurn = true;
        Item.scale = 1.3f;
    }

    public override void AddRecipes()
    {
        var recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.DemoniteBar, 13);
        recipe.AddIngredient(ItemID.MoltenPickaxe);
        recipe.AddIngredient(ModContent.ItemType<GalaxyiteBar>(), 12);
        recipe.AddTile(TileID.DemonAltar);
        recipe.Register();

        recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.CrimtaneBar, 13);
        recipe.AddIngredient(ItemID.MoltenPickaxe);
        recipe.AddIngredient(ModContent.ItemType<GalaxyiteBar>(), 12);
        recipe.AddTile(TileID.DemonAltar);
        recipe.Register();
    }
}