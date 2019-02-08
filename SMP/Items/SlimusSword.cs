using Terraria.ID;
using Terraria.ModLoader;

namespace SMP.Items
{
	public class SlimusSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slimus Sword");
			Tooltip.SetDefault("It feels mysterious and legendary, and it's a little slimy...");
		}
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Seaweed);
			item.value = 10000;
			item.rare = -12;
			item.maxStack = 1;
			item.shoot = mod.ProjectileType("SwordOnSlime_Proj");
			item.buffType = mod.BuffType("SwordOnSlime_Buff");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
