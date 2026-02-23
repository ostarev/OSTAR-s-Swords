using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace OSTARsSWORDS.Content.Items.Materials;

public class SwordMatter : ModItem
{
	public override void SetStaticDefaults()
	{
		// 6 is the speed (lower = faster), 4 is the number of frames
		Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(4, 4));
		
		// This set allows the item to animate while dropped in the world
		ItemID.Sets.AnimatesAsSoul[Item.type] = true;
		ItemID.Sets.ItemIconPulse[Item.type] = true;
		ItemID.Sets.ItemNoGravity[Item.type] = true;
    }

	public override void SetDefaults()
	{
		Item.width = 12;
		Item.height = 12;
		Item.maxStack = 9999;
		Item.value = 0;
		Item.rare = ItemRarityID.Orange;
		Item.ResearchUnlockCount = 25;
	}

	public static readonly Terraria.Audio.SoundStyle GhostSound = new("OSTARsSWORDS/Sounds/Ghost")
	{
		Volume = 0.15f,
		Pitch = 0.66f,
		MaxInstances = 1
	};

	public override void OnSpawn(IEntitySource source)
	{
		if (source is EntitySource_Loot lootSource && lootSource.Entity is NPC)
		{
			Terraria.Audio.SoundEngine.PlaySound(GhostSound, Item.position);
		}
	}
}
