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
		public bool Description;
		UIPanel panel = new UIPanel();
		UIText SkillPointsLeftText = new UIText("");
		UIText LevelText = new UIText("");
		UIText XPText = new UIText("");
		UIImageButton RangersDexterity = new UIImageButton(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/RangersDexterity1"));
		UIImageButton HunterAcrobatics = new UIImageButton(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/HunterAcrobatics0"));
		public override void OnInitialize()
		{
			panel.Height.Set(800, 0);
			panel.Width.Set(600, 0);
			panel.HAlign = 0.5f;
			panel.VAlign = 0.2f;
			panel.Top.Set(0f, 0f);
			panel.BackgroundColor = new Color(30, 30, 30, 150);
			Append(panel);


			SkillPointsLeftText.HAlign = 0.65f;
			SkillPointsLeftText.VAlign = 1f;
			SkillPointsLeftText.Height.Set(915, 0);
			SkillPointsLeftText.Width.Set(0, 0);
			Append(SkillPointsLeftText);

			LevelText.HAlign = 0.5f;
			LevelText.VAlign = 1f;
			LevelText.Height.Set(950, 0);
			LevelText.Width.Set(0, 0);
			Append(LevelText);

			XPText.VAlign = 1f;
			XPText.Height.Set(915, 0);
			XPText.Width.Set(1050, 0);
			Append(XPText);


			RangersDexterity.Width.Set(40, 0);
			RangersDexterity.Height.Set(40, 0);
			RangersDexterity.HAlign = 0.5f;
			RangersDexterity.VAlign = 0.4f;
			RangersDexterity.OnMouseOut += MouseOut;
			RangersDexterity.OnClick += new MouseEvent(OnRangersDexterity);
			panel.Append(RangersDexterity);

			HunterAcrobatics.Width.Set(40, 0);
			HunterAcrobatics.Height.Set(40, 0);
			HunterAcrobatics.HAlign = 0.7f;
			HunterAcrobatics.VAlign = 0.4f;
			HunterAcrobatics.OnMouseOut += MouseOut;
			HunterAcrobatics.OnClick += new MouseEvent(OnHunterAcrobatics);
			panel.Append(HunterAcrobatics);
		}
		private void MouseOut(UIMouseEvent evt, UIElement listeningElement)
		{
				Description = false;
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
			if (Description == false)
			{
				if (RangersDexterity.IsMouseHovering)
				{
					Main.NewTextMultiline("[c/ffec00:Ranger's Dexterity]\nMultiplies your movement speed by 20% while holding a Ranged Weapon\n");
					Description = true;
				}
				if (HunterAcrobatics.IsMouseHovering)
				{
					Main.NewTextMultiline("[c/ffec00:Hunter Acrobatics]\nIncreased jump height while holding a Bow\n[c/b40000:Requires: Ranger's Dexterity]\n");
					Description = true;
				}
			}

				if (untoldplayer.RangerDexterity == false)
				{
					RangersDexterity.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/RangersDexterity1"));
					HunterAcrobatics.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/HunterAcrobatics0"));
				}
				else
				{
					RangersDexterity.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/RangersDexterity2"));
				if (untoldplayer.HunterAcrobatics == false)
				{
					HunterAcrobatics.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/HunterAcrobatics1"));
				}
				else
				{
					HunterAcrobatics.SetImage(ModContent.GetTexture("UntoldLegends/Sprites/Ranged/HunterAcrobatics2"));
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
	}
}