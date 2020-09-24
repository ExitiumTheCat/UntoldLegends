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
		public override void OnInitialize()
		{
			panel.Height.Set(800, 0);
			panel.Width.Set(600, 0);
			panel.HAlign = 0.5f;
			panel.VAlign = 0.2f;
			panel.Top.Set(0f, 0f);
			panel.BackgroundColor = new Color(30, 30, 30, 150);
			Append(panel);

			SkillPointsLeftText.HAlign = 0.33f;
			SkillPointsLeftText.VAlign = 1f;
			SkillPointsLeftText.Height.Set(915, 0);
			SkillPointsLeftText.Width.Set(0, 0);
			Append(SkillPointsLeftText);

			LevelText.HAlign = 0.318f;
			LevelText.VAlign = 1f;
			LevelText.Height.Set(950, 0);
			LevelText.Width.Set(0, 0);
			Append(LevelText);

			XPText.HAlign = 0.33f;
			XPText.VAlign = 1f;
			XPText.Height.Set(885, 0);
			XPText.Width.Set(0, 0);
			Append(XPText);

			DescriptionText.HAlign = 0.55f;
			DescriptionText.VAlign = 1f;
			DescriptionText.Height.Set(950, 0);
			DescriptionText.Width.Set(0, 0);
			Append(DescriptionText);



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
			AerialTakeover.VAlign = 0.61f;
			AerialTakeover.OnClick += new MouseEvent(OnAerialTakeover);
			panel.Append(AerialTakeover);

			HunterInstincts.Width.Set(64, 0);
			HunterInstincts.Height.Set(64, 0);
			HunterInstincts.HAlign = 0.83f;
			HunterInstincts.VAlign = 0.49f;
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
			SuperSharpenedArrows.VAlign = 0.28f;
			SuperSharpenedArrows.OnClick += new MouseEvent(OnSuperSharpenedArrows);
			panel.Append(SuperSharpenedArrows);

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
			XPText.SetText("Experience: " + untoldplayer.Experience);

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

			if (untoldplayer.RangerDexterity == false)
				{
					RangersDexterity.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/RangersDexterity1"));
				}
				else
				{
					RangersDexterity.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/RangersDexterity2"));
				if (untoldplayer.SharpenedArrows == false)
				{
					SharpenedArrows.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/SharpenedArrows1"));
				}
				else
				{
					SharpenedArrows.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/SharpenedArrows2"));
					if (untoldplayer.SuperSharpenedArrows == false)
					{
						SuperSharpenedArrows.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/SuperSharpenedArrows1"));
					}
					else
					{
						SuperSharpenedArrows.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/SuperSharpenedArrows2"));
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
			if (untoldplayer.RangerDexterity == false && untoldplayer.SkillPoints >= 1)
			{
				untoldplayer.RangerDexterity = true;
				untoldplayer.SkillPoints--;
			}
		}
		private void OnHunterAcrobatics(UIMouseEvent evt, UIElement listeningElement)
		{
			UntoldPlayer untoldplayer = Main.LocalPlayer.GetModPlayer<UntoldPlayer>();
			if (untoldplayer.HunterAcrobatics == false && untoldplayer.SkillPoints >= 1 && untoldplayer.RangerDexterity == true)
			{
				untoldplayer.HunterAcrobatics = true;
				untoldplayer.SkillPoints--;
			}
		}
		private void OnAerialTakeover(UIMouseEvent evt, UIElement listeningElement)
		{
			UntoldPlayer untoldplayer = Main.LocalPlayer.GetModPlayer<UntoldPlayer>();
			if (untoldplayer.AerialTakeover == false && untoldplayer.SkillPoints >= 1 && untoldplayer.HunterAcrobatics == true)
			{
				untoldplayer.AerialTakeover = true;
				untoldplayer.SkillPoints--;
			}
		}
		private void OnHunterInstincts(UIMouseEvent evt, UIElement listeningElement)
		{
			UntoldPlayer untoldplayer = Main.LocalPlayer.GetModPlayer<UntoldPlayer>();
			if (untoldplayer.HunterInstincts == false && untoldplayer.SkillPoints >= 1 && untoldplayer.HunterAcrobatics == true)
			{
				untoldplayer.HunterInstincts = true;
				untoldplayer.SkillPoints--;
			}
		}
		private void OnSharpenedArrows(UIMouseEvent evt, UIElement listeningElement)
		{
			UntoldPlayer untoldplayer = Main.LocalPlayer.GetModPlayer<UntoldPlayer>();
			if (untoldplayer.SharpenedArrows == false && untoldplayer.SkillPoints >= 1 && untoldplayer.RangerDexterity == true)
			{
				untoldplayer.SharpenedArrows = true;
				untoldplayer.SkillPoints--;
			}
		}
		private void OnSuperSharpenedArrows(UIMouseEvent evt, UIElement listeningElement)
		{
			UntoldPlayer untoldplayer = Main.LocalPlayer.GetModPlayer<UntoldPlayer>();
			if (untoldplayer.SuperSharpenedArrows == false && untoldplayer.SkillPoints >= 1 && untoldplayer.SharpenedArrows == true)
			{
				untoldplayer.SuperSharpenedArrows = true;
				untoldplayer.SkillPoints--;
			}
		}
	}
}