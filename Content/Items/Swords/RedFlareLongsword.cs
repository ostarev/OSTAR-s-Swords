using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords;

public class RedFlareLongsword : ModItem
{
	public override void SetStaticDefaults()
	{
	}

	public override void SetDefaults()
	{
		Item.width = 60;
		Item.height = 60;
		Item.scale = 1.1f;
		Item.rare = ItemRarityID.Red;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.useTime = 30;
		Item.useAnimation = 30;
		Item.damage = 74;
		Item.knockBack = 5f;
		Item.shoot = ProjectileID.DD2SquireSonicBoom;
		Item.shootSpeed = 30f;
		Item.UseSound = SoundID.Item45;
		Item.value = Item.sellPrice(0, 10, 0, 0);
		Item.autoReuse = true;
		Item.DamageType = DamageClass.Melee;
		Item.ResearchUnlockCount = 1;
	}

	public override void MeleeEffects(Player player, Rectangle hitbox)
	{
		if (Main.rand.Next(2) == 0)
		{
			int dust = Dust.NewDust(new Vector2((float)hitbox.X, (float)hitbox.Y), hitbox.Width, hitbox.Height, DustID.LifeDrain, 0f, 0f, 100, default(Color), 2f);
			Main.dust[dust].noGravity = true;
		}
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.HellstoneBar, 25);
		recipe.AddIngredient(ItemID.RedTorch, 25);
		recipe.AddIngredient(ItemID.Ruby, 50);
		recipe.AddIngredient(ItemID.SoulofFright, 20);
		recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
		recipe.AddIngredient(Mod, "DeathSword", 1);
		recipe.AddIngredient(Mod, "DamascusBar", 20);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.Register();
	}

	public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
	{
		target.AddBuff(BuffID.OnFire, 500, false);
	}
}
