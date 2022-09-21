using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.IO;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace InstinctMod.Common.Systems;

public class GenSystem : ModSystem
{
    public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
    {
        var index = tasks.FindIndex(genPass => genPass.Name.Equals("Final Cleanup"));

        if (index == -1)
        {
            return;
        }

        tasks.Insert(index + 1, new MagnesiumOrePass("Instinct: Magnesium Ores", 237.4298f));
        tasks.Insert(index + 2, new GalaxyOrePass("Instinct: Galaxy Ores", 237.4298f));
    }
}

public class MagnesiumOrePass : GenPass
{
    public MagnesiumOrePass(string name, float loadWeight) : base(name, loadWeight)
    {
    }

    protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
    {
        progress.Message = "Instinct: Magnesium Ore";

        for (var k = 0; k < (int)(Main.maxTilesX * Main.maxTilesY * 6E-05); k++)
        {
            var x = WorldGen.genRand.Next(0, 300);
            var y = WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY);
            var strength = WorldGen.genRand.Next(6, 10);
            var steps = WorldGen.genRand.Next(2, 6);
            WorldGen.OreRunner(x, y, strength, steps, (ushort)ModContent.TileType<Content.Tiles.MagnesiumOre>());
        }
    }
}

public class GalaxyOrePass : GenPass
{
    public GalaxyOrePass(string name, float loadWeight) : base(name, loadWeight)
    {
    }

    protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
    {
        progress.Message = "Instinct: Galaxy Ore";
        for (var k = 0; k < Main.maxTilesX * 0.004;) // 0.0008*5
        {
            var x = WorldGen.genRand.Next(0, Main.maxTilesX);
            var y = WorldGen.genRand.Next(0, (int) WorldGen.worldSurfaceHigh);
            var strength = WorldGen.genRand.Next(6, 8);
            var steps = WorldGen.genRand.Next(2, 6);
            var tile = Framing.GetTileSafely(x, y);
            if (tile.HasTile && TileID.Sets.Clouds[tile.TileType])
            {
                TileID.Sets.CanBeClearedDuringOreRunner[tile.TileType] = true;
                WorldGen.OreRunner(x, y, strength, steps, (ushort)ModContent.TileType<Content.Tiles.GalaxyOre>());
                TileID.Sets.CanBeClearedDuringOreRunner[tile.TileType] = false;
                k++;
            }
        }
    }
}