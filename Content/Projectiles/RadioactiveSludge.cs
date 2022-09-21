using Terraria.ModLoader;

namespace InstinctMod.Content.Projectiles;

public class RadioactiveSludge : ModProjectile
{
    public override void SetDefaults()
    {
        Projectile.width = 30;
        Projectile.height = 30;
        Projectile.friendly = true;
        Projectile.hostile = false;
        Projectile.tileCollide = true;
        Projectile.ignoreWater = false;
        Projectile.penetrate = 100;
        Projectile.DamageType = DamageClass.Melee;
        Projectile.aiStyle = 1;
        Projectile.light = 0.75f;
    }
}