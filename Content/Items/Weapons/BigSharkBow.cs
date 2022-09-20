using Terraria.ID;
using Terraria.ModLoader;

namespace InstinctMod.Content.Items.Weapons;

public class BigSharkBow : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Big Shark Bow");
        Tooltip.SetDefault("'Small Shark Bow's older brother'");
    }

    public override void SetDefaults()
    {
        Item.damage = 32;
        Item.DamageType = DamageClass.Ranged;
        Item.width = 40;
        Item.height = 40;
        Item.useTime = 9;
        Item.useAnimation = 9;
        Item.useStyle = ItemUseStyleID.Shoot;
        Item.knockBack = 1;
        Item.value = 10000;
        Item.rare = ItemRarityID.Green;
        Item.UseSound = SoundID.Item5;
        Item.autoReuse = true;
        Item.shoot = ProjectileID.WoodenArrowFriendly;
        Item.useAmmo = AmmoID.Arrow;
        Item.shootSpeed = 500f;
        Item.crit = 6;
        Item.noMelee = true;
    }

    public override void AddRecipes()
    {
        var recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.SharkFin, 5);
        recipe.AddIngredient(ItemID.SoulofMight, 10);
        recipe.AddIngredient(ModContent.ItemType<IllegalBowParts>());
        recipe.AddIngredient(ModContent.ItemType<SmallSharkBow>());
        recipe.AddTile(TileID.MythrilAnvil);
        recipe.Register();
    }
}