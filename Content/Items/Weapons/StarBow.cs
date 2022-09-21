using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace InstinctMod.Content.Items.Weapons;

public class StarBow : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Star Bow");
        Tooltip.SetDefault("'So, you picked this over a cannon.'");
    }

    public override void SetDefaults()
    {
        Item.damage = 61;
        Item.DamageType = DamageClass.Ranged;
        Item.width = 40;
        Item.height = 40;
        Item.useTime = 13;
        Item.useAnimation = 13;
        Item.useStyle = ItemUseStyleID.Shoot;
        Item.knockBack = 0;
        Item.value = 20000;
        Item.rare = ItemRarityID.Green;
        Item.autoReuse = true;
        Item.shoot = 955;
        Item.useAmmo = AmmoID.FallenStar;
        Item.shootSpeed = 20f;
        Item.crit = 12;
        Item.noMelee = true;
    }

    public override void AddRecipes()
    {
        var recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.FallenStar, 10);
        recipe.AddIngredient(ItemID.MeteoriteBar, 10);
        recipe.AddIngredient(ModContent.ItemType<SmallSharkBow>(), 1);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();
    }

    public override Vector2? HoldoutOffset()
    {
        return new Vector2(2, 0);
    }
}