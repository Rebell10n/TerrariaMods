using ExampleMod.Items;
using ExampleMod.NPCs.PuritySpirit;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace ExampleMod
{
	// ModPlayer classes provide a way to attach data to Players and act on that data. ExamplePlayer has a lot of functionality related to 
	// several effects and items in ExampleMod. See SimpleModPlayer for a very simple example of how ModPlayer classes work.
	public class ExamplePlayer : ModPlayer
	{
    private const int saveVersion = 0;
		public int score;
		public bool eFlames;
		public bool elementShield;
		public int elementShields;
		private int elementShieldTimer;
		public int elementShieldPos;
		public int lockTime;
		public bool voidMonolith = false;
		public int heroLives;
		public int reviveTime;
		public int constantDamage;
		public float percentDamage;
		public float defenseEffect = -1f;
		public bool badHeal;
		public int healHurt;
		public bool nullified;
		public int purityDebuffCooldown;
		public bool purityMinion;
		public bool examplePet;
		public bool exampleLightPet;
		public bool exampleShield;
		public bool infinity;
		// These 5 relate to ExampleCostume.
		public bool blockyAccessoryPrevious;
		public bool blockyAccessory;
		public bool blockyHideVanity;
		public bool blockyForceVanity;
		public bool blockyPower;
		public bool nonStopParty; // The value of this bool can't be calculated by other clients automatically since it is set in ExampleUI. This bool is synced by SendClientChanges.
		public bool examplePersonGiftReceived;

		private const int maxExampleLifeFruits = 10;
		public int exampleLifeFruits;

		public bool ZoneExample;

		public override void ResetEffects() {
			eFlames = false;
			elementShield = false;
			constantDamage = 0;
			percentDamage = 0f;
			defenseEffect = -1f;
			badHeal = false;
			healHurt = 0;
			nullified = false;
			purityMinion = false;
			examplePet = false;
			exampleLightPet = false;
			exampleShield = false;
			infinity = false;
			blockyAccessoryPrevious = blockyAccessory;
			blockyAccessory = blockyHideVanity = blockyForceVanity = blockyPower = false;

			player.statLifeMax2 += exampleLifeFruits * 2;
 
  }
