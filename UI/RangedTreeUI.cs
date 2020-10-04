using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.ModLoader;
using Terraria.UI;
using UntoldLegends;

namespace UntoldLegends.UI
{
	internal class RangedSkillTreeUI : UIState
	{
		UIPanel panel = new UIPanel();
		UIText SkillPointsLeftText = new UIText("");
		UIText LevelText = new UIText("");
		UIText XPText = new UIText("");
		UIText DescriptionText = new UIText("");
		UIImageButton RangersDexterity = new UIImageButton(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/RangersDexterity1"));
		UIImageButton HunterAcrobatics = new UIImageButton(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/HunterAcrobatics0"));
		UIImageButton AerialTakeover = new UIImageButton(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/AerialTakeover0"));
		UIImageButton HunterInstincts = new UIImageButton(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/HunterInstincts0"));
		UIImageButton SharpenedArrows = new UIImageButton(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/SharpenedArrows0"));
		UIImageButton SuperSharpenedArrows = new UIImageButton(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/SuperSharpenedArrows0"));
		UIImageButton AchillesHeel = new UIImageButton(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/AchillesHeel0"));
		UIImageButton PoisonedArrows = new UIImageButton(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/PoisonedArrows0"));
		UIImageButton EaglesEyes = new UIImageButton(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/EaglesEyes0"));
		UIImageButton MarksmansConcentration = new UIImageButton(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/MarksmansConcentration0"));
		UIImageButton HuntersFocus = new UIImageButton(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/HuntersFocus0"));
		UIImageButton Camouflage = new UIImageButton(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/Camouflage0"));
		UIImageButton ShadowForm = new UIImageButton(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/ShadowForm0"));
		public override void OnInitialize()
		{
			panel.Height.Set(800, 0);
			panel.Width.Set(600, 0);
			panel.HAlign = 0.5f;
			panel.VAlign = 0.2f;
			panel.Top.Set(0f, 0f);
			panel.BackgroundColor = new Color(30, 30, 30, 150);
			Append(panel);

			LevelText.HAlign = 0.01f;
			LevelText.VAlign = 0.02f;
			LevelText.Height.Set(0, 0);
			LevelText.Width.Set(0, 0);

			SkillPointsLeftText.HAlign = 0.01f;
			SkillPointsLeftText.VAlign = 0.055f;
			SkillPointsLeftText.Height.Set(0, 0);
			SkillPointsLeftText.Width.Set(0, 0);

			XPText.HAlign = 0.01f;
			XPText.VAlign = 0.09f;
			XPText.Height.Set(0, 0);
			XPText.Width.Set(0, 0);

			DescriptionText.HAlign = 0.8f;
			DescriptionText.VAlign = 0.02f;
			DescriptionText.Height.Set(0, 0);
			DescriptionText.Width.Set(0, 0);

			//HAlign 18
			//VAlign 12

			RangersDexterity.Width.Set(64, 0);
			RangersDexterity.Height.Set(64, 0);
			RangersDexterity.HAlign = 0.5f;
			RangersDexterity.VAlign = 0.5f;
			RangersDexterity.OnClick += new MouseEvent(OnRangersDexterity);
			panel.Append(RangersDexterity);

			HunterAcrobatics.Width.Set(64, 0);
			HunterAcrobatics.Height.Set(64, 0);
			HunterAcrobatics.HAlign = 0.68f;
			HunterAcrobatics.VAlign = 0.5f;
			HunterAcrobatics.OnClick += new MouseEvent(OnHunterAcrobatics);
			panel.Append(HunterAcrobatics);

			AerialTakeover.Width.Set(64, 0);
			AerialTakeover.Height.Set(64, 0);
			AerialTakeover.HAlign = 0.68f;
			AerialTakeover.VAlign = 0.62f;
			AerialTakeover.OnClick += new MouseEvent(OnAerialTakeover);
			panel.Append(AerialTakeover);

			HunterInstincts.Width.Set(64, 0);
			HunterInstincts.Height.Set(64, 0);
			HunterInstincts.HAlign = 0.86f;
			HunterInstincts.VAlign = 0.50f;
			HunterInstincts.OnClick += new MouseEvent(OnHunterInstincts);
			panel.Append(HunterInstincts);

			SharpenedArrows.Width.Set(64, 0);
			SharpenedArrows.Height.Set(64, 0);
			SharpenedArrows.HAlign = 0.5f;
			SharpenedArrows.VAlign = 0.38f;
			SharpenedArrows.OnClick += new MouseEvent(OnSharpenedArrows);
			panel.Append(SharpenedArrows);

			SuperSharpenedArrows.Width.Set(64, 0);
			SuperSharpenedArrows.Height.Set(64, 0);
			SuperSharpenedArrows.HAlign = 0.5f;
			SuperSharpenedArrows.VAlign = 0.26f;
			SuperSharpenedArrows.OnClick += new MouseEvent(OnSuperSharpenedArrows);
			panel.Append(SuperSharpenedArrows);

			AchillesHeel.Width.Set(64, 0);
			AchillesHeel.Height.Set(64, 0);
			AchillesHeel.HAlign = 0.32f;
			AchillesHeel.VAlign = 0.26f;
			AchillesHeel.OnClick += new MouseEvent(OnAchillesHeel);
			panel.Append(AchillesHeel);

			PoisonedArrows.Width.Set(64, 0);
			PoisonedArrows.Height.Set(64, 0);
			PoisonedArrows.HAlign = 0.68f;
			PoisonedArrows.VAlign = 0.38f;
			PoisonedArrows.OnClick += new MouseEvent(OnPoisonedArrows);
			panel.Append(PoisonedArrows);

			EaglesEyes.Width.Set(64, 0);
			EaglesEyes.Height.Set(64, 0);
			EaglesEyes.HAlign = 0.5f;
			EaglesEyes.VAlign = 0.62f;
			EaglesEyes.OnClick += new MouseEvent(OnEaglesEyes);
			panel.Append(EaglesEyes);

			MarksmansConcentration.Width.Set(64, 0);
			MarksmansConcentration.Height.Set(64, 0);
			MarksmansConcentration.HAlign = 0.5f;
			MarksmansConcentration.VAlign = 0.74f;
			MarksmansConcentration.OnClick += new MouseEvent(OnMarksmansConcentration);
			panel.Append(MarksmansConcentration);

			HuntersFocus.Width.Set(64, 0);
			HuntersFocus.Height.Set(64, 0);
			HuntersFocus.HAlign = 0.5f;
			HuntersFocus.VAlign = 0.86f;
			HuntersFocus.OnClick += new MouseEvent(OnHuntersFocus);
			panel.Append(HuntersFocus);

			Camouflage.Width.Set(64, 0);
			Camouflage.Height.Set(64, 0);
			Camouflage.HAlign = 0.68f;
			Camouflage.VAlign = 0.86f;
			Camouflage.OnClick += new MouseEvent(OnCamouflage);
			panel.Append(Camouflage);

			ShadowForm.Width.Set(64, 0);
			ShadowForm.Height.Set(64, 0);
			ShadowForm.HAlign = 0.68f;
			ShadowForm.VAlign = 0.98f;
			ShadowForm.OnClick += new MouseEvent(OnShadowForm);
			panel.Append(ShadowForm);

			panel.Append(LevelText);
			panel.Append(SkillPointsLeftText);
			panel.Append(XPText);
			panel.Append(DescriptionText);
		}
		public override void Update(GameTime gameTime)
		{
			UntoldPlayer untoldplayer = Main.LocalPlayer.GetModPlayer<UntoldPlayer>();

			if (Main.LocalPlayer.GetModPlayer<UntoldPlayer>().Level == 15)
			{
				LevelText.SetText("Level: MAX");
			}
			else
			{
				LevelText.SetText("Level: " + untoldplayer.Level);
			}
			SkillPointsLeftText.SetText("Skill Points: " + untoldplayer.SkillPoints);
			XPText.SetText("XP: " + untoldplayer.Experience + "/" + untoldplayer.XPLimit);

			if (panel.IsMouseHovering)
			{
				Main.LocalPlayer.mouseInterface = true;
			}
				if (RangersDexterity.IsMouseHovering)
				{
					DescriptionText.SetText("[c/ffec00:Ranger's Dexterity]\nMultiplies your movement speed by 20%\nwhile holding a Ranged Weapon");
				}
				if (HunterAcrobatics.IsMouseHovering)
				{
					DescriptionText.SetText("[c/ffec00:Hunter Acrobatics]\nIncreased jump height while holding a Bow\n[c/b40000:Requires: Ranger's Dexterity]");
				}
				if (AerialTakeover.IsMouseHovering)
				{
					DescriptionText.SetText("[c/ffec00:Aerial Takeover]\nBows deal 5% more damage when you have\nvertical velocity\nEnemies with vertical velocity take extra damage\n[c/b40000:Requires: Hunter Acrobatics]");
				}
				if (HunterInstincts.IsMouseHovering)
				{
					DescriptionText.SetText("[c/ffec00:Hunter Instincts]\nWhile holding a bow, you can clearly see\nall traps around you\n[c/b40000:Requires: Hunter Acrobatics]");
				}
				if (SharpenedArrows.IsMouseHovering)
				{
					DescriptionText.SetText("[c/ffec00:Sharpened Arrows]\nIncreases armor penetration by 5 while\nwhile holding a Bow\n[c/b40000:Requires: Ranger's Dexterity]");
				}
				if (SuperSharpenedArrows.IsMouseHovering)
				{
					DescriptionText.SetText("[c/ffec00:Super Sharpened Arrows]\nWooden Arrows penetrate 1 enemy\n[c/b40000:Requires: Sharpened Arrows]");
				}
				if (AchillesHeel.IsMouseHovering)
				{
					DescriptionText.SetText("[c/ffec00:Achilles' Heel]\nWhen hitting a non-Boss enemy, you have\na 2% chance of instakilling them\n[c/b40000:Requires: SS Arrows & Lucky Shots]");
				}
				if (PoisonedArrows.IsMouseHovering)
				{
					DescriptionText.SetText("[c/ffec00:Poisoned Arrows]\nArrows have a 15% chance of inflicting\nPoisoned\n[c/b40000:Requires: Sharpened Arrows]");
				}
				if (EaglesEyes.IsMouseHovering)
				{
					DescriptionText.SetText("[c/ffec00:Eagle's Eyes]\n3% increased critical chance\n[c/b40000:Requires: Ranger's Dexterity]");
				}
				if (MarksmansConcentration.IsMouseHovering)
				{
					DescriptionText.SetText("[c/ffec00:Marksman's Concentration]\nWhile holding a Bow and not running fast,\nvision decreased but damage increased by 5%\n[c/b40000:Requires: Eagle's Eyes]");
				}
				if (HuntersFocus.IsMouseHovering)
				{
					DescriptionText.SetText("[c/ffec00:Hunter's Focus]\nWhile holding a Bow and not running fast,\nyou can clearly see all enemies near you\n[c/b40000:Requires: Marksman's Concentration]");
				}
				if (Camouflage.IsMouseHovering)
				{
					DescriptionText.SetText("[c/ffec00:Camouflage]\nWhile standing still or walking very\nslowly, enemy agro is reduced\n[c/b40000:Requires: Hunter's Focus]");
				}
				if (ShadowForm.IsMouseHovering)
				{
					DescriptionText.SetText("[c/ffec00:Shadow Form (Active Ability)]\nEnemy aggro is greatly reduced\nand movement speed is increased\nDuration: 5 Seconds | Cooldown: 20 Seconds\n[c/b40000:Requires: Camouflage]");
				}

			if (untoldplayer.RangerDexterity == false)
				{
					RangersDexterity.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/RangersDexterity1"));
				}
				else
				{
					RangersDexterity.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/RangersDexterity2"));
				if (untoldplayer.EaglesEyes == false)
				{
					EaglesEyes.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/EaglesEyes1"));
				}
				else
				{
					EaglesEyes.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/EaglesEyes2"));
					if (untoldplayer.MarksmansConcentration == false)
					{
						MarksmansConcentration.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/MarksmansConcentration1"));
					}
					else
					{
						MarksmansConcentration.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/MarksmansConcentration2"));
						if (untoldplayer.HuntersFocus == false)
						{
							HuntersFocus.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/HuntersFocus1"));
						}
						else
						{
							HuntersFocus.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/HuntersFocus2"));
							if (untoldplayer.Camouflage == false)
							{
								Camouflage.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/Camouflage1"));
							}
							else
							{
								Camouflage.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/Camouflage2"));
								if (untoldplayer.ShadowFormSkill == false)
								{
									ShadowForm.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/ShadowForm1"));
								}
								else
								{
									ShadowForm.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/ShadowForm2"));
								}
							}
						}
					}
				}
				if (untoldplayer.SharpenedArrows == false)
				{
					SharpenedArrows.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/SharpenedArrows1"));
				}
				else
				{
					SharpenedArrows.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/SharpenedArrows2"));
					if (untoldplayer.PoisonedArrows == false)
					{
						PoisonedArrows.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/PoisonedArrows1"));
					}
					else
					{
						PoisonedArrows.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/PoisonedArrows2"));
					}
					if (untoldplayer.SuperSharpenedArrows == false)
					{
						SuperSharpenedArrows.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/SuperSharpenedArrows1"));
					}
					else
					{
						SuperSharpenedArrows.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/SuperSharpenedArrows2"));
						if (untoldplayer.AchillesHeel)
						{
							AchillesHeel.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/AchillesHeel2"));
						}
						else if (!untoldplayer.AchillesHeel && untoldplayer.LuckyShots)
						{
							AchillesHeel.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/AchillesHeel1"));
						}
					}
				}
				if (untoldplayer.HunterAcrobatics == false)
				{
					HunterAcrobatics.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/HunterAcrobatics1"));
				}
				else
				{
					HunterAcrobatics.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/HunterAcrobatics2"));
					if (untoldplayer.AerialTakeover == false)
					{
						AerialTakeover.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/AerialTakeover1"));
					}
					else
					{
						AerialTakeover.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/AerialTakeover2"));
					}
					if (untoldplayer.HunterInstincts == false)
					{
						HunterInstincts.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/HunterInstincts1"));
					}
					else
					{
						HunterInstincts.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/HunterInstincts2"));
					}
				}
			}
		}
		private void OnRangersDexterity(UIMouseEvent evt, UIElement listeningElement)
		{
			UntoldPlayer untoldplayer = Main.LocalPlayer.GetModPlayer<UntoldPlayer>();
			if (!untoldplayer.RangerDexterity && untoldplayer.SkillPoints >= 1)
			{
				untoldplayer.RangerDexterity = true;
				untoldplayer.SkillPoints--;
			}
		}
		private void OnHunterAcrobatics(UIMouseEvent evt, UIElement listeningElement)
		{
			UntoldPlayer untoldplayer = Main.LocalPlayer.GetModPlayer<UntoldPlayer>();
			if (!untoldplayer.HunterAcrobatics && untoldplayer.SkillPoints >= 1 && untoldplayer.RangerDexterity)
			{
				untoldplayer.HunterAcrobatics = true;
				untoldplayer.SkillPoints--;
			}
		}
		private void OnAerialTakeover(UIMouseEvent evt, UIElement listeningElement)
		{
			UntoldPlayer untoldplayer = Main.LocalPlayer.GetModPlayer<UntoldPlayer>();
			if (!untoldplayer.AerialTakeover && untoldplayer.SkillPoints >= 1 && untoldplayer.HunterAcrobatics)
			{
				untoldplayer.AerialTakeover = true;
				untoldplayer.SkillPoints--;
			}
		}
		private void OnHunterInstincts(UIMouseEvent evt, UIElement listeningElement)
		{
			UntoldPlayer untoldplayer = Main.LocalPlayer.GetModPlayer<UntoldPlayer>();
			if (!untoldplayer.HunterInstincts && untoldplayer.SkillPoints >= 1 && untoldplayer.HunterAcrobatics)
			{
				untoldplayer.HunterInstincts = true;
				untoldplayer.SkillPoints--;
			}
		}
		private void OnSharpenedArrows(UIMouseEvent evt, UIElement listeningElement)
		{
			UntoldPlayer untoldplayer = Main.LocalPlayer.GetModPlayer<UntoldPlayer>();
			if (!untoldplayer.SharpenedArrows && untoldplayer.SkillPoints >= 1 && untoldplayer.RangerDexterity)
			{
				untoldplayer.SharpenedArrows = true;
				untoldplayer.SkillPoints--;
			}
		}
		private void OnSuperSharpenedArrows(UIMouseEvent evt, UIElement listeningElement)
		{
			UntoldPlayer untoldplayer = Main.LocalPlayer.GetModPlayer<UntoldPlayer>();
			if (!untoldplayer.SuperSharpenedArrows && untoldplayer.SkillPoints >= 1 && untoldplayer.SharpenedArrows)
			{
				untoldplayer.SuperSharpenedArrows = true;
				untoldplayer.SkillPoints--;
			}
		}
		private void OnAchillesHeel(UIMouseEvent evt, UIElement listeningElement)
		{
			UntoldPlayer untoldplayer = Main.LocalPlayer.GetModPlayer<UntoldPlayer>();
			if (!untoldplayer.AchillesHeel && untoldplayer.SkillPoints >= 1 && untoldplayer.SuperSharpenedArrows && untoldplayer.LuckyShots)
			{
				untoldplayer.AchillesHeel = true;
				untoldplayer.SkillPoints--;
			}
		}
		private void OnPoisonedArrows(UIMouseEvent evt, UIElement listeningElement)
		{
			UntoldPlayer untoldplayer = Main.LocalPlayer.GetModPlayer<UntoldPlayer>();
			if (!untoldplayer.PoisonedArrows && untoldplayer.SkillPoints >= 1 && untoldplayer.SharpenedArrows)
			{
				untoldplayer.PoisonedArrows = true;
				untoldplayer.SkillPoints--;
			}
		}
		private void OnEaglesEyes(UIMouseEvent evt, UIElement listeningElement)
		{
			UntoldPlayer untoldplayer = Main.LocalPlayer.GetModPlayer<UntoldPlayer>();
			if (!untoldplayer.EaglesEyes && untoldplayer.SkillPoints >= 1 && untoldplayer.RangerDexterity)
			{
				untoldplayer.EaglesEyes = true;
				untoldplayer.SkillPoints--;
			}
		}
		private void OnMarksmansConcentration(UIMouseEvent evt, UIElement listeningElement)
		{
			UntoldPlayer untoldplayer = Main.LocalPlayer.GetModPlayer<UntoldPlayer>();
			if (!untoldplayer.MarksmansConcentration && untoldplayer.SkillPoints >= 1 && untoldplayer.EaglesEyes)
			{
				untoldplayer.MarksmansConcentration = true;
				untoldplayer.SkillPoints--;
			}
		}
		private void OnHuntersFocus(UIMouseEvent evt, UIElement listeningElement)
		{
			UntoldPlayer untoldplayer = Main.LocalPlayer.GetModPlayer<UntoldPlayer>();
			if (!untoldplayer.HuntersFocus && untoldplayer.SkillPoints >= 1 && untoldplayer.MarksmansConcentration)
			{
				untoldplayer.HuntersFocus = true;
				untoldplayer.SkillPoints--;
			}
		}
		private void OnCamouflage(UIMouseEvent evt, UIElement listeningElement)
		{
			UntoldPlayer untoldplayer = Main.LocalPlayer.GetModPlayer<UntoldPlayer>();
			if (!untoldplayer.Camouflage && untoldplayer.SkillPoints >= 1 && untoldplayer.HuntersFocus)
			{
				untoldplayer.Camouflage = true;
				untoldplayer.SkillPoints--;
			}
		}
		private void OnShadowForm(UIMouseEvent evt, UIElement listeningElement)
		{
			UntoldPlayer untoldplayer = Main.LocalPlayer.GetModPlayer<UntoldPlayer>();
			if (!untoldplayer.ShadowFormSkill && untoldplayer.SkillPoints >= 1 && untoldplayer.Camouflage)
			{
				untoldplayer.ShadowFormSkill = true;
				untoldplayer.SkillPoints--;
			}
		}
	}
}