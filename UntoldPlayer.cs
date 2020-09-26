using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World;
using System.Collections.Generic;
using Terraria.ModLoader.IO;
using UntoldLegends;
using System;
using Terraria.GameInput;

namespace UntoldLegends
{
    class UntoldPlayer : ModPlayer
    {
        public int Experience;
        public int Level;
        public int SkillPoints;
        public int XPLimit;
        //Melee Bools
        //Ranged Bools
        public bool RangerDexterity;
        public bool HunterAcrobatics;
        public bool AerialTakeover;
        public bool HunterInstincts;
        public bool SharpenedArrows;
        public bool SuperSharpenedArrows;
        public bool AchillesHeel;
        public bool PoisonedArrows;
        public bool EaglesEyes;
        public bool MarksmansConcentration;
        public bool HuntersFocus;
        public bool Camouflage;
        public bool ShadowFormSkill = true;
        public bool ShadowFormActivated = true;
        public bool ShadowArrows = true;
        public bool ShadowBullets = true;
        public bool BetterGunpowder;
        public bool DimensionalMagazines;
        public bool DimensionalBullets = true;
        public bool LuckyShots = true;
        public bool GoldenFingers;
        public bool Speedy = true;
        public bool FasterGelCombustion = true;
        public bool Stress = true;
        public bool BulletStorm = true;
        public bool BulletHell;
        //Magic Bools
        //Summoner Bools
        public override TagCompound Save()
        {
            return new TagCompound
            {
                     //Meele Tags
                     //Ranged Tags
                     {"Experience", Experience},
                     {"Level", Level},
                     {"SkillPoints", SkillPoints},
                     {"XPLimit", XPLimit},
                     {"RangerDexterity", RangerDexterity},
                     {"HunterAcrobatics", HunterAcrobatics},
                     {"AerialTakeover", AerialTakeover},
                     {"HunterInstincts", HunterInstincts},
                     {"SharpenedArrows", SharpenedArrows},
                     {"SuperSharpenedArrows", SuperSharpenedArrows},
                     {"AchillesHeel", AchillesHeel},
                     {"PoisonedArrows", PoisonedArrows},
                     {"EaglesEyes", EaglesEyes},
                     {"MarksmansConcentration", MarksmansConcentration},
                     {"HuntersFocus", HuntersFocus},
                     {"Camouflage", Camouflage},
                     {"ShadowFormSkill", ShadowFormSkill},
                     {"ShadowArrows", ShadowArrows},
                     {"ShadowBullets", ShadowBullets},
                     {"BetterGunpowder", BetterGunpowder},
                     {"DimensionalMagazines", DimensionalMagazines},
                     {"DimensionalBullets", DimensionalBullets},
                     {"LuckyShots", LuckyShots},
                     {"GoldenFingers", GoldenFingers},
                     {"Speedy", Speedy},
                     {"FasterGelCombustion", FasterGelCombustion},
                     {"Stress", Stress},
                     {"BulletStorm", BulletStorm},
                     {"BulletHell", BulletHell},
                     //Magic Tags
                     //Summoner Tags
            };
        }

        public override void Load(TagCompound tag)
        {
                 //Melee Tags
                 //RangedTags
                 if (tag.ContainsKey("Experience"))
                    Experience = tag.GetInt("Experience");
                 if (tag.ContainsKey("Level"))
                    Level = tag.GetInt("Level");
                 if (tag.ContainsKey("SkillPoints"))
                    SkillPoints = tag.GetInt("SkillPoints");
                 if (tag.ContainsKey("XPLimit"))
                    XPLimit = tag.GetInt("XPLimit");
                 if (tag.ContainsKey("HunterAcrobatics"))
                    HunterAcrobatics = tag.GetBool("HunterAcrobatics");
                 if (tag.ContainsKey("AerialTakeover"))
                    AerialTakeover = tag.GetBool("AerialTakeover");
                 if (tag.ContainsKey("HunterInstincts"))
                    HunterInstincts = tag.GetBool("HunterInstincts");
                 if (tag.ContainsKey("SharpenedArrows"))
                    SharpenedArrows = tag.GetBool("SharpenedArrows");
                 if (tag.ContainsKey("SuperSharpenedArrows"))
                    SuperSharpenedArrows = tag.GetBool("SuperSharpenedArrows");
                 if (tag.ContainsKey("AchillesHeel"))
                    AchillesHeel = tag.GetBool("AchillesHeel");
                 if (tag.ContainsKey("PoisonedArrows"))
                    PoisonedArrows = tag.GetBool("PoisonedArrows");
                 if (tag.ContainsKey("EaglesEyes"))
                    EaglesEyes = tag.GetBool("EaglesEyes");
                 if (tag.ContainsKey("MarksmansConcentration"))
                    MarksmansConcentration = tag.GetBool("MarksmansConcentration");
                 if (tag.ContainsKey("HuntersFocus"))
                    HuntersFocus = tag.GetBool("HuntersFocus");
                 if (tag.ContainsKey("Camouflage"))
                    Camouflage = tag.GetBool("Camouflage");
                 if (tag.ContainsKey("ShadowFormSkill"))
                    ShadowFormSkill = tag.GetBool("ShadowFormSkill");
                 if (tag.ContainsKey("ShadowArrows"))
                    ShadowArrows = tag.GetBool("ShadowArrows");
                 if (tag.ContainsKey("ShadowBullets"))
                    ShadowBullets = tag.GetBool("ShadowBullets");
                 if (tag.ContainsKey("BetterGunpowder"))
                    BetterGunpowder = tag.GetBool("BetterGunpowder");
                 if (tag.ContainsKey("DimensionalMagazines"))
                    DimensionalMagazines = tag.GetBool("DimensionalMagazines");
                 if (tag.ContainsKey("DimensionalBullets"))
                    DimensionalBullets = tag.GetBool("DimensionalBullets");
                 if (tag.ContainsKey("LuckyShots"))
                    LuckyShots = tag.GetBool("LuckyShots");
                 if (tag.ContainsKey("GoldenFingers"))
                    GoldenFingers = tag.GetBool("GoldenFingers");
                 if (tag.ContainsKey("Speedy"))
                    Speedy = tag.GetBool("Speedy");
                 if (tag.ContainsKey("FasterGelCombustion"))
                    FasterGelCombustion = tag.GetBool("FasterGelCombustion");
                 if (tag.ContainsKey("Stress"))
                    Stress = tag.GetBool("Stress");
                 if (tag.ContainsKey("BulletStorm"))
                    BulletStorm = tag.GetBool("BulletStorm");
                 if (tag.ContainsKey("BulletHell"))
                    BulletHell = tag.GetBool("BulletHell");
                 //Magic Tags
                 //Summoner Tags
        }
        public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            if (target.life <= 0)
            {
                if (NPC.downedGolemBoss)
                {
                    Experience += Main.rand.Next(50, 101);
                }
                else
                {
                    if (Main.hardMode)
                    {
                        Experience += Main.rand.Next(37, 75);
                    }
                    else
                    {
                        Experience += Main.rand.Next(25, 51);
                    }
                }
            }

            if (PoisonedArrows == true && player.HeldItem.useAmmo == AmmoID.Arrow)
            {
                if (Main.rand.NextFloat() < .15f)
                {
                    target.AddBuff(BuffID.Poisoned, 300);
                }
            }
            if (GoldenFingers == true && player.HeldItem.useAmmo == AmmoID.Bullet)
            {
                if (Main.rand.NextFloat() < .10f)
                {
                    target.AddBuff(BuffID.Midas, 600);
                }
            }
            if (DimensionalMagazines == true && player.HeldItem.useAmmo == AmmoID.Bullet)
            {
                if (Main.rand.NextFloat() < .15f)
                {
                    player.QuickSpawnItem(ItemID.MusketBall);
                }
            }
            if (BulletHell == true && player.HeldItem.useAmmo == AmmoID.Bullet)
            {
                if (Main.rand.NextFloat() < .33f)
                {
                    target.AddBuff(BuffID.OnFire, 600);
                }
            }
            if (LuckyShots == true && crit)
            {
                //eeeeeeeeeeeeeeeeee
            }
        }
        public override void PreUpdate()
        {
            if (UntoldConfigClient.Instance.BalanceChanges == true)
            {
                player.rangedDamage -= 0.07f;
            }
            switch (Level)
            {
                case (0):
                    XPLimit = 2000;
                    break;
                case (1):
                    XPLimit = 2800;
                    break;
                case (2):
                    XPLimit = 3920;
                    break;
                case (3):
                    XPLimit = 5488;
                    break;
                case (4):
                    XPLimit = 7683;
                    break;
                case (5):
                    XPLimit = 10756;
                    break;
                case (6):
                    XPLimit = 15059;
                    break;
                case (7):
                    XPLimit = 19576;
                    break;
                case (8):
                    XPLimit = 25449;
                    break;
                case (9):
                    XPLimit = 33084;
                    break;
                case (10):
                    XPLimit = 43010;
                    break;
                case (11):
                    XPLimit = 51612;
                    break;
                case (12):
                    XPLimit = 61934;
                    break;
                case (13):
                    XPLimit = 74321;
                    break;
                case (14):
                    XPLimit = 89185;
                    break;
            }
            if (Experience >= XPLimit && Level < 15)
            {
                Level++;
                SkillPoints++;
                CombatText.NewText(player.Hitbox, Color.White, "Level Up!", dramatic: true);
            }
        }

        public override void PostUpdateBuffs()
        {
            if (HunterAcrobatics == true && player.HeldItem.useAmmo == AmmoID.Arrow)
            {
                player.jumpSpeedBoost += 1.8f;
                player.extraFall += 8;
            }
            if (AerialTakeover == true && player.HeldItem.useAmmo == AmmoID.Arrow)
            {
                player.autoJump = true;

                if (player.velocity.Y > 0.00000000001 || player.velocity.Y < -0.00000000001)
                {
                    player.rangedDamage += 0.06f;
                }
            }
            if (HunterInstincts == true && player.HeldItem.useAmmo == AmmoID.Arrow)
            {
                player.dangerSense = true;
            }
            if (SharpenedArrows == true && player.HeldItem.useAmmo == AmmoID.Arrow)
            {
                player.armorPenetration += 5;
            }
            if (EaglesEyes == true)
            {
                player.magicCrit += 3;
                player.meleeCrit += 3;
                player.rangedCrit += 3;
                player.thrownCrit += 3;
            }
            if (BetterGunpowder == true && player.HeldItem.useAmmo == AmmoID.Bullet)
            {
                player.rangedDamage += 0.05f;
            }
            //Walking Slowly
            if (player.velocity.X < 5 && player.velocity.X > -5)
            {
                if (MarksmansConcentration == true && player.HeldItem.useAmmo == AmmoID.Arrow)
                {
                    player.rangedDamage += 0.05f;
                    player.AddBuff(BuffID.Blackout, 1);
                }
                if (HuntersFocus == true && player.HeldItem.useAmmo == AmmoID.Arrow)
                {
                    player.detectCreature = true;
                }
                if (Camouflage == true)
                {
                    player.aggro -= 450;
                }
            }
            if (Stress == true && player.statLife < 150)
            {
                player.allDamage += 0.10f;
            }
        }
        public override void PostUpdateRunSpeeds()
        {
            if (RangerDexterity == true && player.HeldItem.ranged)
            {
                player.moveSpeed *= 1.20f;
                player.maxRunSpeed *= 1.20f;
                player.accRunSpeed *= 1.20f;
            }
        }
    }
 }
