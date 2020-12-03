using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MixedMod.Items.Tools
{
	public class MixedPick : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A pickaxe that emanates raw power.");
		}

		public override void SetDefaults()
		{
			item.damage = 100;
			item.melee = true;
			item.width = 64;
			item.height = 64;
			item.useTime = 5;
			item.useAnimation = 5;
			item.pick = 230;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 15;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<MixedBar>(), 16);
			recipe.AddTile(ModContent.TileType<MythrilAnvil>());
			recipe.AddIngredient(ModContent.ItemType<Glass>(), 1);
			recipe.AddIngredient(ItemID.Wood, 150);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.NextBool(10))
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, ModContent.DustType<Sparkle>());
			}
		}
	}
}