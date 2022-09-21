using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace InstinctMod.Content.Tiles;

public class GalaxyOre : ModTile
{
    public override void SetStaticDefaults()
    {
        TileID.Sets.Ore[Type] = true;
        Main.tileSpelunker[Type] = true;
        Main.tileOreFinderPriority[Type] = 410; // Metal Detector value, see https://terraria.gamepedia.com/Metal_Detector
        Main.tileShine2[Type] = true;
        Main.tileShine[Type] = 975;
        Main.tileMergeDirt[Type] = true;
        Main.tileSolid[Type] = true;
        Main.tileBlockLight[Type] = true;

        var name = CreateMapEntryName();
        name.SetDefault("GalaxyOre");
        AddMapEntry(new Color(152, 171, 198), name);

        DustType = 84;
        ItemDrop = ModContent.ItemType<Items.GalaxyOre>();
        HitSound = SoundID.Tink;
        // MineResist = 4f;
        // MinPick = 200;
    }
}