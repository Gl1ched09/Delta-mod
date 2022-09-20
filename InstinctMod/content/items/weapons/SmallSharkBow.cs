using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace InstinctMod.content.items.weapons
{
    public class SmallSharkBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Small Shark Bow"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
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
            Item.useStyle = 5;
            Item.knockBack = 0;
            Item.value = 8000;
            Item.rare = 2;
            Item.UseSound = SoundID.Item5;
            Item.autoReuse = true;
            Item.shoot = 1;
            Item.useAmmo = AmmoID.Arrow;
            Item.shootSpeed = 260f;
            Item.crit = 2;
            Item.noMelee = true;
        }

       
    }
}


