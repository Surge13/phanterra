using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace phanterra.Items.Weapons
{
	public class summit : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Summit");
			Tooltip.SetDefault("80% chance not to consume ammo.\nConverts all arrows into random arrows.");
		}

		public override void SetDefaults() {
			item.damage = 113; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
			item.crit = 40;
			item.ranged = true; // sets the damage type to ranged
			item.width = 40; // hitbox width of the item
			item.height = 20; // hitbox height of the item
			item.useTime = 4; // The item's use time in ticks (60 ticks == 1 second.)
			item.useAnimation = 16; // The length of the item's use animation in ticks (60 ticks == 1 second.)
			item.useStyle = ItemUseStyleID.HoldingOut; // how you use the item (swinging, holding out, etc)
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
			item.value = 1000000; // how much the item sells for (measured in copper)
			item.rare = ItemRarityID.Red; // the color that the item's name will be in-game
			item.UseSound = SoundID.Item5; // The sound that this item plays when used.
			item.autoReuse = true; // if you can hold click to automatically use it again
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 32f; // the speed of the projectile (measured in pixels per frame)
			item.useAmmo = AmmoID.Arrow; // The "ammo Id" of the ammo item that this weapon uses. Note that this is not an item Id, but just a magic value.
			item.reuseDelay = 20;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "phanterra", 1);
			recipe.AddIngredient(ItemID.DD2PhoenixBow, 1);
			recipe.AddIngredient(ItemID.DD2BetsyBow, 1);
			recipe.AddIngredient(ItemID.Phantasm, 1);
			recipe.AddIngredient(ItemID.Marrow, 1);
			recipe.AddIngredient(ItemID.PulseBow, 1);
			recipe.AddIngredient(ItemID.ChlorophyteShotbow, 1);
			recipe.AddIngredient(ItemID.TitaniumRepeater, 1);
			recipe.AddIngredient(ItemID.Tsunami, 1);
			recipe.AddIngredient(ItemID.PlatinumBow, 1);
			recipe.AddIngredient(ItemID.LunarBar, 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();

			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(null, "phanterra", 1);
			recipe2.AddIngredient(ItemID.DD2PhoenixBow, 1);
			recipe2.AddIngredient(ItemID.DD2BetsyBow, 1);
			recipe2.AddIngredient(ItemID.Phantasm, 1);
			recipe2.AddIngredient(ItemID.Marrow, 1);
			recipe2.AddIngredient(ItemID.PulseBow, 1);
			recipe2.AddIngredient(ItemID.ChlorophyteShotbow, 1);
			recipe2.AddIngredient(ItemID.TitaniumRepeater, 1);
			recipe2.AddIngredient(ItemID.Tsunami, 1);
			recipe2.AddIngredient(ItemID.GoldBow, 1);
			recipe2.AddIngredient(ItemID.LunarBar, 20);
			recipe2.AddTile(TileID.MythrilAnvil);
			recipe2.SetResult(this);
			recipe2.AddRecipe();

			ModRecipe recipe3 = new ModRecipe(mod);
			recipe3.AddIngredient(null, "phanterra", 1);
			recipe3.AddIngredient(ItemID.DD2PhoenixBow, 1);
			recipe3.AddIngredient(ItemID.DD2BetsyBow, 1);
			recipe3.AddIngredient(ItemID.Phantasm, 1);
			recipe3.AddIngredient(ItemID.Marrow, 1);
			recipe3.AddIngredient(ItemID.PulseBow, 1);
			recipe3.AddIngredient(ItemID.ChlorophyteShotbow, 1);
			recipe3.AddIngredient(ItemID.AdamantiteRepeater, 1);
			recipe3.AddIngredient(ItemID.Tsunami, 1);
			recipe3.AddIngredient(ItemID.PlatinumBow, 1);
			recipe3.AddIngredient(ItemID.LunarBar, 20);
			recipe3.AddTile(TileID.MythrilAnvil);
			recipe3.SetResult(this);
			recipe3.AddRecipe();

			ModRecipe recipe4 = new ModRecipe(mod);
			recipe4.AddIngredient(null, "phanterra", 1);
			recipe4.AddIngredient(ItemID.DD2PhoenixBow, 1);
			recipe4.AddIngredient(ItemID.DD2BetsyBow, 1);
			recipe4.AddIngredient(ItemID.Phantasm, 1);
			recipe4.AddIngredient(ItemID.Marrow, 1);
			recipe4.AddIngredient(ItemID.PulseBow, 1);
			recipe4.AddIngredient(ItemID.ChlorophyteShotbow, 1);
			recipe4.AddIngredient(ItemID.AdamantiteRepeater, 1);
			recipe4.AddIngredient(ItemID.Tsunami, 1);
			recipe4.AddIngredient(ItemID.GoldBow, 1);
			recipe4.AddIngredient(ItemID.LunarBar, 20);
			recipe4.AddTile(TileID.MythrilAnvil);
			recipe4.SetResult(this);
			recipe4.AddRecipe();
		}

		public override bool PreDrawInInventory(SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale)
		{
     		 //New item inventory sprite is Items/someItem.png
      		spriteBatch.Draw(mod.GetTexture("Items/Weapons/summitinv"),
           	 new Rectangle((int)position.X, (int)position.Y, (int)(frame.Width * scale), (int)(frame.Height * scale)),
           	 drawColor);
      		return false; //Stops default drawing
		}

		/*
		 * Feel free to uncomment any of the examples below to see what they do
		 */

		// What if I wanted this gun to have a 38% chance not to consume ammo?
		public override bool ConsumeAmmo(Player player)
		{
			return !(player.itemAnimation < item.useAnimation - 2);
			return Main.rand.NextFloat() >= .80f;
		}

		// What if I wanted it to work like Uzi, replacing regular bullets with High Velocity Bullets?
		// Uzi/Molten Fury style: Replace normal Bullets with High Velocity
		/*public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.Bullet) // or ProjectileID.WoodenArrowFriendly
			{
				type = ProjectileID.BulletHighVelocity; // or ProjectileID.FireArrow;
			}
			return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
		}*/

		// What if I wanted it to shoot like a shotgun?
		// Shotgun style: Multiple Projectiles, Random spread 
		/*public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 4 + Main.rand.Next(2); // 4 or 5 shots
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // 30 degree spread.
				// If you want to randomize the speed to stagger the projectiles
				// float scale = 1f - (Main.rand.NextFloat() * .3f);
				// perturbedSpeed = perturbedSpeed * scale; 
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false; // return false because we don't want tmodloader to shoot projectile
		}*/

		// What if I wanted an inaccurate gun? (Chain Gun)
		// Inaccurate Gun style: Single Projectile, Random spread 
		/*public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;
			return true;
		}*/

		// What if I wanted multiple projectiles in a even spread? (Vampire Knives) 
		// Even Arc style: Multiple Projectile, Even Spread 
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{ 
			type = Main.rand.Next(new int[] { type, ProjectileID.MoonlordArrow, ProjectileID.WoodenArrowFriendly, ProjectileID.FireArrow, ProjectileID.UnholyArrow, ProjectileID.JestersArrow, ProjectileID.HellfireArrow, ProjectileID.HolyArrow, ProjectileID.CursedArrow, ProjectileID.BoneArrow, ProjectileID.ChlorophyteArrow, ProjectileID.IchorArrow, ProjectileID.VenomArrow, ProjectileID.BoneArrowFromMerchant });
			
			float rotation = MathHelper.ToRadians(1);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
			for (int i = 0; i < 1; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i )) * 16f; // Watch out for dividing by 0 if there is only 1 projectile.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, Main.rand.Next(new int[] { type, ProjectileID.MoonlordArrow, ProjectileID.WoodenArrowFriendly, ProjectileID.FireArrow, ProjectileID.UnholyArrow, ProjectileID.JestersArrow, ProjectileID.HellfireArrow, ProjectileID.HolyArrow, ProjectileID.CursedArrow, ProjectileID.BoneArrow, ProjectileID.ChlorophyteArrow, ProjectileID.IchorArrow, ProjectileID.VenomArrow, ProjectileID.BoneArrowFromMerchant }), damage, knockBack, player.whoAmI);
				Projectile.NewProjectile(position.X-30, position.Y-30, perturbedSpeed.X, perturbedSpeed.Y, Main.rand.Next(new int[] { type, ProjectileID.MoonlordArrow, ProjectileID.WoodenArrowFriendly, ProjectileID.FireArrow, ProjectileID.UnholyArrow, ProjectileID.JestersArrow, ProjectileID.HellfireArrow, ProjectileID.HolyArrow, ProjectileID.CursedArrow, ProjectileID.BoneArrow, ProjectileID.ChlorophyteArrow, ProjectileID.IchorArrow, ProjectileID.VenomArrow, ProjectileID.BoneArrowFromMerchant }), damage, knockBack, player.whoAmI);
				Projectile.NewProjectile(position.X-30, position.Y+30, perturbedSpeed.X, perturbedSpeed.Y, Main.rand.Next(new int[] { type, ProjectileID.MoonlordArrow, ProjectileID.WoodenArrowFriendly, ProjectileID.FireArrow, ProjectileID.UnholyArrow, ProjectileID.JestersArrow, ProjectileID.HellfireArrow, ProjectileID.HolyArrow, ProjectileID.CursedArrow, ProjectileID.BoneArrow, ProjectileID.ChlorophyteArrow, ProjectileID.IchorArrow, ProjectileID.VenomArrow, ProjectileID.BoneArrowFromMerchant }), damage, knockBack, player.whoAmI);
				Projectile.NewProjectile(position.X, position.Y+60, perturbedSpeed.X, perturbedSpeed.Y, Main.rand.Next(new int[] { type, ProjectileID.MoonlordArrow, ProjectileID.WoodenArrowFriendly, ProjectileID.FireArrow, ProjectileID.UnholyArrow, ProjectileID.JestersArrow, ProjectileID.HellfireArrow, ProjectileID.HolyArrow, ProjectileID.CursedArrow, ProjectileID.BoneArrow, ProjectileID.ChlorophyteArrow, ProjectileID.IchorArrow, ProjectileID.VenomArrow, ProjectileID.BoneArrowFromMerchant }), damage, knockBack, player.whoAmI);
				Projectile.NewProjectile(position.X+20, position.Y-70, perturbedSpeed.X, perturbedSpeed.Y, Main.rand.Next(new int[] { type, ProjectileID.MoonlordArrow, ProjectileID.WoodenArrowFriendly, ProjectileID.FireArrow, ProjectileID.UnholyArrow, ProjectileID.JestersArrow, ProjectileID.HellfireArrow, ProjectileID.HolyArrow, ProjectileID.CursedArrow, ProjectileID.BoneArrow, ProjectileID.ChlorophyteArrow, ProjectileID.IchorArrow, ProjectileID.VenomArrow, ProjectileID.BoneArrowFromMerchant }), damage, knockBack, player.whoAmI);
				Projectile.NewProjectile(position.X-20, position.Y-70, perturbedSpeed.X, perturbedSpeed.Y, Main.rand.Next(new int[] { type, ProjectileID.MoonlordArrow, ProjectileID.WoodenArrowFriendly, ProjectileID.FireArrow, ProjectileID.UnholyArrow, ProjectileID.JestersArrow, ProjectileID.HellfireArrow, ProjectileID.HolyArrow, ProjectileID.CursedArrow, ProjectileID.BoneArrow, ProjectileID.ChlorophyteArrow, ProjectileID.IchorArrow, ProjectileID.VenomArrow, ProjectileID.BoneArrowFromMerchant }), damage, knockBack, player.whoAmI);
				Projectile.NewProjectile(position.X+70, position.Y-70, perturbedSpeed.X, perturbedSpeed.Y, Main.rand.Next(new int[] { type, ProjectileID.MoonlordArrow, ProjectileID.WoodenArrowFriendly, ProjectileID.FireArrow, ProjectileID.UnholyArrow, ProjectileID.JestersArrow, ProjectileID.HellfireArrow, ProjectileID.HolyArrow, ProjectileID.CursedArrow, ProjectileID.BoneArrow, ProjectileID.ChlorophyteArrow, ProjectileID.IchorArrow, ProjectileID.VenomArrow, ProjectileID.BoneArrowFromMerchant }), damage, knockBack, player.whoAmI);
				Projectile.NewProjectile(position.X+10, position.Y+60, perturbedSpeed.X, perturbedSpeed.Y, Main.rand.Next(new int[] { type, ProjectileID.MoonlordArrow, ProjectileID.WoodenArrowFriendly, ProjectileID.FireArrow, ProjectileID.UnholyArrow, ProjectileID.JestersArrow, ProjectileID.HellfireArrow, ProjectileID.HolyArrow, ProjectileID.CursedArrow, ProjectileID.BoneArrow, ProjectileID.ChlorophyteArrow, ProjectileID.IchorArrow, ProjectileID.VenomArrow, ProjectileID.BoneArrowFromMerchant }), damage, knockBack, player.whoAmI);
				Projectile.NewProjectile(position.X+70, position.Y+50, perturbedSpeed.X, perturbedSpeed.Y, Main.rand.Next(new int[] { type, ProjectileID.MoonlordArrow, ProjectileID.WoodenArrowFriendly, ProjectileID.FireArrow, ProjectileID.UnholyArrow, ProjectileID.JestersArrow, ProjectileID.HellfireArrow, ProjectileID.HolyArrow, ProjectileID.CursedArrow, ProjectileID.BoneArrow, ProjectileID.ChlorophyteArrow, ProjectileID.IchorArrow, ProjectileID.VenomArrow, ProjectileID.BoneArrowFromMerchant }), damage, knockBack, player.whoAmI);
				Projectile.NewProjectile(position.X+70, position.Y, perturbedSpeed.X, perturbedSpeed.Y, Main.rand.Next(new int[] { type, ProjectileID.MoonlordArrow, ProjectileID.WoodenArrowFriendly, ProjectileID.FireArrow, ProjectileID.UnholyArrow, ProjectileID.JestersArrow, ProjectileID.HellfireArrow, ProjectileID.HolyArrow, ProjectileID.CursedArrow, ProjectileID.BoneArrow, ProjectileID.ChlorophyteArrow, ProjectileID.IchorArrow, ProjectileID.VenomArrow, ProjectileID.BoneArrowFromMerchant }), damage, knockBack, player.whoAmI);
			}
			return false;
		}

		// Help, my gun isn't being held at the handle! Adjust these 2 numbers until it looks right.
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-90, 0);
		}

		// How can I make the shots appear out of the muzzle exactly?
		// Also, when I do this, how do I prevent shooting through tiles?
		/*public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 25f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			return true;
		}*/

		// How can I get a "Clockwork Assault Rifle" effect?
		// 3 round burst, only consume 1 ammo for burst. Delay between bursts, use reuseDelay
		/*	The following changes to SetDefaults()
		 	item.useAnimation = 12;
			item.useTime = 4;
			item.reuseDelay = 14;
		public override bool ConsumeAmmo(Player player)
		{
			// Because of how the game works, player.itemAnimation will be 11, 7, and finally 3. (useAnimation - 1, then - useTime until less than 0.) 
			// We can get the Clockwork Assault Riffle Effect by not consuming ammo when itemAnimation is lower than the first shot.
			return !(player.itemAnimation < item.useAnimation - 2);
		}*/

		// How can I shoot 2 different projectiles at the same time?
		/*public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Here we manually spawn the 2nd projectile, manually specifying the projectile type that we wish to shoot.
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.GrenadeI, damage, knockBack, player.whoAmI);
			// By returning true, the vanilla behavior will take place, which will shoot the 1st projectile, the one determined by the ammo.
			return true;
		}*/

		// How can I choose between several projectiles randomly?
		/*public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Here we randomly set type to either the original (as defined by the ammo), a vanilla projectile, or a mod projectile.
			type = Main.rand.Next(new int[] { type, ProjectileID.GoldenBullet, ProjectileType<Projectiles.ExampleBullet>() });
			return true;
		}*/
	}
}