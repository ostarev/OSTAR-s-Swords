using Luminance;
using Luminance.Core.Graphics;
using Microsoft.Xna.Framework;
using OSTARsSWORDS.Content.Buffs.WoltazhaBuff;
using OSTARsSWORDS.Content.Particles;
using OSTARsSWORDS.Rarities;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace OSTARsSWORDS.Content.Items.Swords.Teski
{
    public class Teski : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 1;
            Item.DamageType = DamageClass.Melee;
            Item.width = 128;
            Item.height = 128;
            Item.scale = 0.75f;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 2;
            Item.value = Item.buyPrice(gold: 99);
            Item.rare = ModContent.RarityType<AbyssalBlue>();
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.ResearchUnlockCount = 1;
            Item.crit = 99;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Burger, 15);
            recipe.AddIngredient(ItemID.HallowedBar, 25);
            recipe.AddIngredient(Mod, "Grease" , 99);
            recipe.AddIngredient(ItemID.SoulofNight, 15);
            recipe.AddIngredient(ItemID.SoulofFright, 15);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }

        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (hit.Crit)
            {
                ScreenShakeSystem.StartShake(10f, 6f, null, 0.8f);
                // Spawn some Luminance particles
                for (int i = 0; i < 30; i++)
                {
                    Vector2 velocity = Main.rand.NextVector2Circular(8f, Main.rand.NextFloat(2f, 24f));
                    Particle1Glow p = new()
                    {
                        Position = target.Center,
                        Velocity = velocity,
                        RotationSpeed = Main.rand.NextFloat(-0.2f, 0.2f),
                        Scale = Vector2.One * Main.rand.NextFloat(0.2f, 0.8f),
                        DrawColor = Color.LightBlue,
                        Lifetime = Main.rand.Next(30, 60)
                    };
                    p.Spawn();
                }
                target.AddBuff(BuffID.Slow, 1800);
                player.AddBuff(ModContent.BuffType<WoltazhaBuff>(), 1800);

            }
            damageDone += (int)(target.life * 0.1f);
            SoundEngine.PlaySound(new SoundStyle("OSTARsSWORDS/Sounds/ClickyHit") { Volume = 0.33f, Pitch = -2.0f }, target.position);
            NPC.HitInfo extraHit = new()
            {
                Damage = damageDone,
                HitDirection = player.direction,
                Crit = false
            };
            target.StrikeNPC(extraHit);
            player.addDPS(damageDone);
        }
    }
}
