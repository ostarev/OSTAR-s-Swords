using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class TheForce : ModItem
{
	public override void SetDefaults()
	{
		Item.width = 64;
		Item.height = 64;
		Item.scale = 1f;
		Item.rare = 4;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 28;
		Item.useAnimation = 28;
		Item.damage = 30;
		Item.knockBack = 5.5f;
		Item.UseSound = SoundID.Item1;
		Item.shoot = 9;
		Item.shootSpeed = 20f;
		Item.value = 74800;
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void MeleeEffects(Player player, Rectangle hitbox)
	{
		if (Main.rand.Next(1) == 0)
		{
			int dust = Dust.NewDust(new Vector2((float)hitbox.X, (float)hitbox.Y), hitbox.Width, hitbox.Height, 15, 0f, 0f, 100, default(Color), 2f);
			Main.dust[dust].noGravity = true;
		}
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.NightsEdge, 1);
		recipe.AddIngredient(Mod, "MasterSword", 1);
		recipe.AddIngredient(Mod, "LavaSword", 1);
		recipe.AddIngredient(175, 15);
		recipe.AddIngredient(Mod, "UpgradeMatter", 1);
		recipe.AddIngredient(Mod, "SwordMatter", 150);
		recipe.AddTile(TileID.DemonAltars);
		recipe.Register();
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.Ichor, 360, false);
		target.AddBuff(BuffID.OnFire, 360, false);
		target.AddBuff(72, 360, false);
	}
}
