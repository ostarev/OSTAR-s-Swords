using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords
{
	public class AllWoodSword : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 26;
			Item.DamageType = DamageClass.Melee;
			Item.width = 54;
			Item.height = 54;
			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 2;
			Item.value = Item.buyPrice(silver: 400);
			Item.rare = ItemRarityID.Yellow;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.ResearchUnlockCount = 1;
			Item.crit = 20;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Wood, 15);
            recipe.AddIngredient(ItemID.RichMahogany, 15);
            recipe.AddIngredient(ItemID.BorealWood, 15);
            recipe.AddIngredient(ItemID.PalmWood, 15);
            recipe.AddIngredient(ItemID.AshWood, 15);
            recipe.AddIngredient(ItemID.Ebonwood, 15);
            recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
            Recipe recipe2 = CreateRecipe();
            recipe2.AddIngredient(ItemID.Wood, 15);
            recipe2.AddIngredient(ItemID.RichMahogany, 15);
            recipe2.AddIngredient(ItemID.BorealWood, 15);
            recipe2.AddIngredient(ItemID.PalmWood, 15);
            recipe2.AddIngredient(ItemID.AshWood, 15);
            recipe2.AddIngredient(ItemID.Shadewood, 15);
            recipe2.AddTile(TileID.WorkBenches);
            recipe2.Register();
        }

        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            target.AddBuff(BuffID.Ichor, 1800);
        }
    }
}
