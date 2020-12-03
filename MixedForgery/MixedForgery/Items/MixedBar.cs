using Terraria.ID;
using Terraria.ModLoader;

namespace MixedForgery.Items
{
	public class MixedBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("MixedBar");
			Tooltip.SetDefault("A bar forged from uncertainty.");
		}
		public override void SetDefaults()
		{

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
			item.value = 100;
			item.rare = ItemRarityID.Blue;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 2);
			recipe.AddIngredient(ItemID.ShroomiteBar, 2);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
