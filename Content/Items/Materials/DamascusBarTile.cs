using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OSTARsSWORDS.Content.Items.Materials;

public class DamascusBarTile : ModTile
{
	public override void SetStaticDefaults()
	{
		Main.tileSolid[Type] = true;
		Main.tileFrameImportant[Type] = true;
		TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
		TileObjectData.addTile(Type);
		LocalizedText name = CreateMapEntryName();
		AddMapEntry(new Color(246, 249, 250), name);
		MinPick = 40;
	}
}
