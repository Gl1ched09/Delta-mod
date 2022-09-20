using Terraria.ID;
using Terraria.ModLoader;

namespace InstinctMod.Content.Items.Weapons;

public class SmallSharkBow : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Small Shark Bow");
        Tooltip.SetDefault("'Big Shark Bow's younger brother'");
    }

    public override void SetDefaults()
    {
        Item.damage = 12;
        Item.DamageType = DamageClass.Ranged;
        Item.width = 40;
        Item.height = 40;
        Item.useTime = 9;
        Item.useAnimation = 9;
        Item.useStyle = ItemUseStyleID.Shoot;
        Item.knockBack = 0;
        Item.value = 8000;
        Item.rare = ItemRarityID.Green;
        Item.UseSound = SoundID.Item5;
        Item.autoReuse = true;
        Item.shoot = ProjectileID.WoodenArrowFriendly;
        Item.useAmmo = AmmoID.Arrow;
        Item.shootSpeed = 260f;
        Item.crit = 2;
        Item.noMelee = true;
    }
}