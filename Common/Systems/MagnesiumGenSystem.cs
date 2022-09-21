using System.Collections.Generic;
using Terraria;
using Terraria.IO;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace InstinctMod.Common.Systems;

public class GenSystem : ModSystem
{
    public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
    {
        var ShiniesIndex = tasks.FindIndex(genPass => genPass.Name.Equals("Shinies"));

        if (ShiniesIndex != -1)
        {
            tasks.Insert(ShiniesIndex + 1, new MagnesiumOrePass("Instinct: Magnesium Ores", 237.4298f));
        }
    }
}

public class MagnesiumOrePass : GenPass
{
    public MagnesiumOrePass(string name, float loadWeight) : base(name, loadWeight)
    {
    }

    protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
    {
        progress.Message = "Generating Modded Ore";

        for (var k = 0; k < (int)(Main.maxTilesX * Main.maxTilesY * 6E-05); k++)
        {
            var x = WorldGen.genRand.Next(0, 300);
            var y = WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY);
            var strength = WorldGen.genRand.Next(3, 6);
            var steps = WorldGen.genRand.Next(2, 6);
            // var tile = Framing.GetTileSafely(x, y);
            // if (tile.HasTile && tile.TileType == TileID.Stone)
            // {
            WorldGen.TileRunner(x, y, strength, steps, ModContent.TileType<Content.Tiles.MagnesiumOre>());
            // }
        }
    }
}
