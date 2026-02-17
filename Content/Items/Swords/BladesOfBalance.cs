using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class BladesOfBalance : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.damage = 51;
		Item.crit = 2;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
		Item.width = 54;
		Item.height = 54;
		Item.useTime = 20;
		Item.useAnimation = 20;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.knockBack = 7f;
		Item.value = Item.sellPrice(0, 5, 0, 0);
		Item.rare = ItemRarityID.LightPurple;
		Item.scale = 1.2f;
		Item.UseSound = SoundID.Item1;
		Item.autoReuse = true;
		Item.useTurn = true;
	}

	public override void MeleeEffects(Player player, Rectangle hitbox)
	{
		if (Main.rand.Next(2) == 0)
		{
			int dust = Dust.NewDust(new Vector2((float)hitbox.X, (float)hitbox.Y), hitbox.Width, hitbox.Height, DustID.PinkTorch, 0f, 0f, 100, default(Color), 2f);
			Main.dust[dust].noGravity = true;
			Main.dust[dust].velocity.X += (float)player.direction * 0f;
			Main.dust[dust].velocity.Y += 0f;
			dust = Dust.NewDust(new Vector2((float)hitbox.X, (float)hitbox.Y), hitbox.Width, hitbox.Height, DustID.VilePowder, 0f, 0f, 100, default(Color), 2f);
			Main.dust[dust].noGravity = true;
			Main.dust[dust].velocity.X += (float)player.direction * 0f;
			Main.dust[dust].velocity.Y += 0f;
		}
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.AncientBattleArmorMaterial, 1);
		recipe.AddIngredient(ItemID.FrostCore, 1);
		recipe.AddIngredient(ItemID.LightShard, 1);
		recipe.AddIngredient(ItemID.DarkShard, 1);
		recipe.AddIngredient(ItemID.SoulofNight, 10);
		recipe.AddIngredient(ItemID.SoulofLight, 10);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}
}
