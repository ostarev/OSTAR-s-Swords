using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using OSTARsSWORDS.Content.Dusts;

namespace OSTARsSWORDS.Content.Items.Materials;

public class DamascusOreTile : ModTile
{
	public override void SetStaticDefaults()
	{
		Main.tileSolid[Type] = true;
		Main.tileMergeDirt[Type] = true;
		Main.tileLighted[Type] = true;
		Main.tileBlockLight[Type] = true;
		Main.tileSpelunker[Type] = true;
		Main.tileOreFinderPriority[Type] = 410;
		Main.tileShine2[Type] = true;
		Main.tileShine[Type] = 975;

		LocalizedText name = CreateMapEntryName();
		AddMapEntry(new Color(210, 210, 240), name);

		TileID.Sets.Ore[Type] = true;
		TileID.Sets.FriendlyFairyCanLureTo[Type] = true;
		VanillaFallbackOnModDeletion = TileID.Silver;
		RegisterItemDrop(ModContent.ItemType<DamascusOre>());
		HitSound = SoundID.Tink;
		DustType = ModContent.DustType<DamascusSparkle>();
		MinPick = 40;
	}

	public override void NumDust(int i, int j, bool fail, ref int num)
	{
		num = fail ? 2 : 4;
	}

	public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
	{
		r = 0.46f;
		g = 0.49f;
		b = 0.5f;
	}
}
