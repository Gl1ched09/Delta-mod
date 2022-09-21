using Terraria.ModLoader;

namespace InstinctMod.Content.Projectiles;

public class CosmosBall : ModProjectile
{
    public override void SetDefaults()
    {
        Projectile.width = 30;
        Projectile.height = 30;
        Projectile.friendly = true;
        Projectile.hostile = false;
        Projectile.tileCollide = false;
        Projectile.ignoreWater = true;
        Projectile.DamageType = DamageClass.Melee;
        Projectile.aiStyle = 0;
        Projectile.light = 0.5f;
        Projectile.damage = -10;
    }
}