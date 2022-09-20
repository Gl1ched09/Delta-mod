using Terraria.ID;
using Terraria.ModLoader;

namespace InstinctMod.Content.Items.Weapons;

public class KnifeOfTheWorld : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Knife Of The World");
        Tooltip.SetDefault("'This knife has destroyed many worlds before'");
    }

    public override void SetDefaults()
    {
        Item.damage = 65;
        Item.DamageType = DamageClass.Melee;
        Item.width = 32;
        Item.height = 32;
        Item.useTime = 16;
        Item.useAnimation = 16;
        Item.useStyle = ItemUseStyleID.Swing;
        Item.knockBack = 4;
        Item.value = 40000;
        Item.rare = ItemRarityID.Orange;
        Item.UseSound = SoundID.Item1;
        Item.autoReuse = true;
        Item.shoot = ModContent.ProjectileType<Projectiles.CosmosBall>();
        Item.shootSpeed = 15f;
    }

    public override void AddRecipes()
    {
        var recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.DemoniteBar, 9);
        recipe.AddIngredient(ItemID.NightsEdge, 1);
        recipe.AddIngredient(ItemID.EnchantedSword, 1);
        recipe.AddIngredient(ModContent.ItemType<GalaxyiteBar>(), 8);
        recipe.AddTile(TileID.DemonAltar);
        recipe.Register();

        recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.CrimtaneBar, 9);
        recipe.AddIngredient(ItemID.NightsEdge, 1);
        recipe.AddIngredient(ItemID.EnchantedSword, 1);
        recipe.AddIngredient(ModContent.ItemType<GalaxyiteBar>(), 8);
        recipe.AddTile(TileID.DemonAltar);
        recipe.Register();
    }
}