using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SwordOnSlime_Proj.Projectiles.Pets
{
	public class SwordOnSlime_Proj : ModProjectile
	{
		public override void SetStaticDefaults() {
			Main.projFrames[projectile.type] = 2;
			Main.projPet[projectile.type] = true;
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(ProjectileID.EyeSpring);
			aiType = ProjectileID.EyeSpring;
		}

		public override bool PreAI() {
			Player player = Main.player[projectile.owner];
			player.eyespring = false; // Relic from aiType
			return true;
		}

		public override void AI() {
			Player player = Main.player[projectile.owner];
			ExamplePlayer modPlayer = player.GetModPlayer<ExamplePlayer>();
			if (player.dead) {
				modPlayer.examplePet = false;
			}
			if (modPlayer.examplePet) {
				projectile.timeLeft = 2;
			}
		}
	}
}
