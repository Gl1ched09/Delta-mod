using Terraria.ModLoader;

namespace InstinctMod.Content.Projectiles;

public class Fireball : ModProjectile
{
    public override void SetDefaults()
    {
        Projectile.width = 20;
        Projectile.height = 20;
        Projectile.friendly = true;
        Projectile.hostile = false;
        Projectile.tileCollide = true;
        Projectile.ignoreWater = true;
        Projectile.DamageType = DamageClass.Melee;
        Projectile.aiStyle = 8;
        Projectile.light = 0.6f;
        Projectile.penetrate = 2;
    }
}