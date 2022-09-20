using Terraria.ID;
using Terraria.ModLoader;

namespace InstinctMod.Content.Items.Weapons;

public class SDMB : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("S.D.M.B");
        Tooltip.SetDefault("'Sub Dolphin Machine Bow'");
    }

    public override void SetDefaults()
    {
        Item.damage = 136;
        Item.DamageType = DamageClass.Ranged;
        Item.width = 40;
        Item.height = 40;
        Item.useTime = 7;
        Item.useAnimation = 7;
        Item.useStyle = ItemUseStyleID.Shoot;
        Item.knockBack = 1;
        Item.value = 130000;
        Item.rare = ItemRarityID.Cyan;
        Item.UseSound = SoundID.Item5;
        Item.autoReuse = true;
        Item.shoot = ProjectileID.WoodenArrowFriendly;
        Item.useAmmo = AmmoID.Arrow;
        Item.shootSpeed = 500f;
        Item.crit = 12;
        Item.noMelee = true;
    }

    public override void AddRecipes()
    {
        var recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.SharkFin, 10);
        recipe.AddIngredient(ItemID.LunarBar, 10);
        recipe.AddIngredient(ItemID.SDMG, 1);
        recipe.AddIngredient(ItemID.Phantasm, 1);
        recipe.AddTile(TileID.LunarCraftingStation);
        recipe.Register();
    }
}