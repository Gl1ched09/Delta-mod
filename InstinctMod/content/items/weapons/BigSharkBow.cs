using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace InstinctMod.content.items.weapons
{
    public class BigSharkBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Big Shark Bow"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
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
            Item.useStyle = 5;
            Item.knockBack = 1;
            Item.value = 10000;
            Item.rare = 2;
            Item.UseSound = SoundID.Item5;
            Item.autoReuse = true;
            Item.shoot = 1;
            Item.useAmmo = AmmoID.Arrow;
            Item.shootSpeed = 500f;
            Item.crit = 6;
            Item.noMelee = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe();
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SharkFin, 5);
            recipe.AddIngredient(ItemID.SoulofMight, 10);
            recipe.AddIngredient(ModContent.ItemType<IllegalBowParts>(), 1);
            recipe.AddIngredient(ModContent.ItemType<SmallSharkBow>(), 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();







        }
    } }
        

       