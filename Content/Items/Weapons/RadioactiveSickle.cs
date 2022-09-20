using Terraria.ID;
using Terraria.ModLoader;

namespace InstinctMod.Content.Items.Weapons;

public class RadioactiveSickle : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Radioactive Sickle");
        Tooltip.SetDefault("'Probably not the safest weapon'");
    }

    public override void SetDefaults()
    {
        Item.damage = 94;
        Item.DamageType = DamageClass.Melee;
        Item.width = 46;
        Item.height = 38;
        Item.useTime = 13;
        Item.useAnimation = 13;
        Item.useStyle = ItemUseStyleID.Swing;
        Item.knockBack = 4;
        Item.value = 40000;
        Item.rare = ItemRarityID.Pink;
        Item.UseSound = SoundID.Item1;
        Item.autoReuse = true;
        Item.shoot = ModContent.ProjectileType<Projectiles.RadioactiveSludge>();
        Item.shootSpeed = 9f;
    }

    public override void AddRecipes()
    {
        var recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.SoulofNight, 4);
        recipe.AddIngredient(ItemID.HallowedBar, 12);
        recipe.AddIngredient(ItemID.Sickle, 1);
        recipe.AddTile(TileID.MythrilAnvil);
        recipe.Register();
    }
}