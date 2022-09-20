using Terraria.ID;
using Terraria.ModLoader;

namespace InstinctMod.Content.Items.Weapons;

public class FieryHellsword : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Fiery Hellsword");
        Tooltip.SetDefault("The same sword that Lucifer himself uses.");
    }

    public override void SetDefaults()
    {
        Item.damage = 90;
        Item.DamageType = DamageClass.Melee;
        Item.width = 54;
        Item.height = 54;
        Item.useTime = 21;
        Item.useAnimation = 21;
        Item.useStyle = ItemUseStyleID.Swing;
        Item.knockBack = 4;
        Item.value = 10000;
        Item.rare = ItemRarityID.Orange;
        Item.UseSound = SoundID.Item1;
        Item.autoReuse = true;
        Item.shoot = ModContent.ProjectileType<Projectiles.Fireball>();
        Item.shootSpeed = 20f;
    }

    public override void AddRecipes()
    {
        var recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.HellstoneBar, 10);
        recipe.AddIngredient(ItemID.SoulofFright, 5);
        recipe.AddIngredient(ItemID.FieryGreatsword, 1);
        recipe.AddIngredient(ItemID.Flamelash, 1);
        recipe.AddTile(TileID.MythrilAnvil);
        recipe.Register();
    }
}