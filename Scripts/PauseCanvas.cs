using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UISystem;
using System;
using DSA.Extensions.Base;

namespace MenuSystem
{
	[System.Serializable]
	public class PauseCanvas : ClickableCanvas, IProcessor<MenuInstruction>, IReceivable<int, MenuInstructionHolder>
	{
		public override ExtensionEnum.Extension Extension { get { return ExtensionEnum.Extension.Menu; } }

		private MenuInstructionHolder instructionHolder;

		private List<int> holderIndicies;

		[SerializeField] private bool isCancelable;
		public bool IsCancelable { get { return isCancelable; } }

		public Func<int, MenuInstructionHolder> ReceiveFunction { get; set; }

		[SerializeField] private List<MenuPanel> activePanels;

		public override void Initialize()
		{
			base.Initialize();
			SetSendActions<MenuInstruction>(Process, 0);
			instructionHolder = ReceiveFunction(1);
			holderIndicies = new List<int>();
			holderIndicies.Add(1);
		}

		public override void DisplayData()
		{
			MenuInstruction[] menuInstructions = instructionHolder.MenuInstructions;
			for (int i = 0; i < menuInstructions.Length; i++)
			{
				menuInstructions[i].SetID(i);
			}
			panels[0].SetData<MenuInstruction>(menuInstructions);
			SetSelectedDisplayable(0, instructionHolder.SelectionIndex);
		}

		public void AddPanelToList(MenuPanel thisPanel)
		{
			if (activePanels == null)
			{
				activePanels = new List<MenuPanel>();
			}
			activePanels.Add(thisPanel);
		}

		public void RemovePanelFromList(MenuPanel thisPanel)
		{
			activePanels.Remove(thisPanel);
		}

		protected override void Show()
		{
			base.Show();
		}

		protected override void Hide()
		{
			if (activePanels != null)
			{
				if (activePanels.Count > 2)
				{
					base.Hide();
					return;
				}
			}
			base.Hide();
		}

		public void Process(MenuInstruction sentItem)
		{
			instructionHolder.SetSelectionIndex(sentItem.ID);
			if (sentItem is CycleMenuInstruction)
			{
				CycleMenuInstruction instruction = (CycleMenuInstruction)sentItem;
				instructionHolder = ReceiveFunction(instruction.HolderIndex);
				holderIndicies.Add(instructionHolder.ID);
				DisplayData();
				return;
			}
			else if (sentItem.Extension == ExtensionEnum.Extension.GamePlay)
			{
				instructionHolder.SetSelectionIndex(0);
			}
			sentItem.Use();
		}

		public override void CancelUI()
		{
			if (holderIndicies.Count > 1)
			{
				holderIndicies.Remove(instructionHolder.ID);
				instructionHolder = ReceiveFunction(holderIndicies[holderIndicies.Count - 1]);
				DisplayData();
				return;
			}
			instructionHolder.SetSelectionIndex(0);
			EndAction();
		}
	}
}