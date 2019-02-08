using Terraria;
using Terraria.ModLoader;

namespace SwordOnSlime.Buffs
{
	public class SwordOnSlime : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Legendary Sword and Slime");
			Description.SetDefault("Uhhhhh, what happens ?");
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			player.buffTime[buffIndex] = 18000;
			player.GetModPlayer<ExamplePlayer>().examplePet = true;
			bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("SwordOnSlime_Proj")] <= 0;
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer) {
				Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("Nothing set for the moment"), 0, 0f, player.whoAmI, 0f, 0f);
			}
		}
	}
}
