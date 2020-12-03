using ExampleMod.Dusts;
using ExampleMod.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MixedMod.Items.Weapons
{
	public class MixedSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A sword eminating raw power.");  //The (English) text shown below your weapon's name
		}

		public override void SetDefaults()
		{
			item.damage = 245; // The damage your item deals
			item.melee = true; // Whether your item is part of the melee class
			item.width = 64; // The item texture's width
			item.height = 64; // The item texture's height
			item.useTime = 10; // The time span of using the weapon. Remember in terraria, 60 frames is a second.
			item.useAnimation = 10; // The time span of the using animation of the weapon, suggest setting it the same as useTim
			item.knockBack = 15; // The force of knockback of the weapon. Maximum is 20
			item.value = Item.buyPrice(gold: 65); // The value of the weapon in copper coins
			item.rare = ItemRarityID.13; // The rarity of the weapon, from -1 to 13. You can also use ItemRarityID.TheColorRarity
			item.UseSound = SoundID.Item1; // The sound when the weapon is being used
			item.autoReuse = true; // Whether the weapon can be used more than once automatically by holding the use button
			item.crit = 18; // The critical strike chance the weapon has. The player, by default, has 4 critical strike chance

			//The useStyle of the item. 
			//Use useStyle 1 for normal swinging or for throwing
			//use useStyle 2 for an item that drinks such as a potion,
			//use useStyle 3 to make the sword act like a shortsword
			//use useStyle 4 for use like a life crystal,
			//and use useStyle 5 for staffs or guns
			item.useStyle = ItemUseStyleID.SwingThrow; // 1 is the useStyle
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            // ItemType<ExampleItem>() is how to get the ExampleItem item, 10 is the amount of that item you need to craft the recipe
            recipe.AddIngredient(ModContent.ItemType<MixedBar>(), 16);
			recipe.AddIngredient(ModContent.ItemType<Glass>(), 1);
			recipe.AddIngredient(ItemID.Wood, 150);
			// You can use recipe.AddIngredient(ItemID.TheItemYouWantToUse, the amount of items needed); for a vanilla item.
			recipe.AddTile(ModContent.TileType<MythrilAnvil>()); // Set the crafting tile to ExampleWorkbench
			recipe.SetResult(this); // Set the result to this item (ExampleSword)
			recipe.AddRecipe(); // When your done, add the recipe
		}
	}
}