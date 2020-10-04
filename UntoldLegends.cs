using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;
using UntoldLegends.UI;

namespace UntoldLegends
{
	public class UntoldLegends : Mod
	{

		internal UserInterface InterfaceSkillTrees;
		internal RangedSkillTreeUI RangedSkillTreeUI;
		private GameTime _lastUpdateUiGameTime;
		public static ModHotKey OpenSkillTree;
		public static ModHotKey ActivateShadowForm;
		public override void Load()
		{
			OpenSkillTree = RegisterHotKey("Open Skill Tree", "K");
			ActivateShadowForm = RegisterHotKey("Activate Shadow Form", "B");
			if (!Main.dedServ)
			{
				InterfaceSkillTrees = new UserInterface();

				RangedSkillTreeUI = new RangedSkillTreeUI();
				RangedSkillTreeUI.Activate();
				InterfaceSkillTrees?.SetState(null);
			}
		}
		public override void Unload()
		{
			OpenSkillTree = null;
			ActivateShadowForm = null;
			RangedSkillTreeUI = null;
		}
		public override void UpdateUI(GameTime gameTime)
		{
			if (OpenSkillTree.JustPressed)
			{
				if (InterfaceSkillTrees.CurrentState != null)
				{
					InterfaceSkillTrees?.SetState(null);
				}
				else
				{
					InterfaceSkillTrees?.SetState(RangedSkillTreeUI);
				}
			}
			_lastUpdateUiGameTime = gameTime;
			if (InterfaceSkillTrees?.CurrentState != null)
			{
				InterfaceSkillTrees.Update(gameTime);
			}
		}
		public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
		{
			int mouseTextIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));
			if (mouseTextIndex != -1)
			{
				layers.Insert(mouseTextIndex, new LegacyGameInterfaceLayer(
					"MyMod: MyInterface",
					delegate
					{
						if (_lastUpdateUiGameTime != null && InterfaceSkillTrees?.CurrentState != null)
						{
							InterfaceSkillTrees.Draw(Main.spriteBatch, _lastUpdateUiGameTime);
						}
						return true;
					},
					   InterfaceScaleType.UI));
			}
		}
	}
}