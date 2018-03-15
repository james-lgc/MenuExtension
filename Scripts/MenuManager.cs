using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using DSA.Extensions.Base;

namespace MenuSystem
{
	[System.Serializable]
	public class MenuManager : ClickableCanvasedManagerBase<PauseCanvas>
	{
		[SerializeField] private ManagerBase[] instructionLinkedManagers;
		[SerializeField] private MenuInstructionHolder[] instructionHolders;
		public override ExtensionEnum Extension { get { return ExtensionEnum.Menu; } }
		[SerializeField] private ManagerBase finalEndManager;

		public override void Initialize()
		{
			canvas.ReceiveFunction = GetMenuInstructionHolder;
			base.Initialize();
			canvas.EndAction = TryToEnd;
			uiController.CancelAction = canvas.CancelUI;
			for (int i = 0; i < instructionHolders.Length; i++)
			{
				instructionHolders[i].SetID(i);
				MenuInstruction[] menuInstructions = instructionHolders[i].MenuInstructions;
				for (int j = 0; j < instructionLinkedManagers.Length; j++)
				{
					for (int k = 0; k < menuInstructions.Length; k++)
					{
						instructionLinkedManagers[j].LinkSendableToStartProcess(menuInstructions[k]);
					}
				}
			}
		}

		protected override void StartProcess()
		{
			base.StartProcess();
			canvas.DisplayData();
		}

		private MenuInstructionHolder GetMenuInstructionHolder(int sentIndex)
		{
			return instructionHolders[sentIndex];
		}

		private void TryToEnd()
		{
			EndProcess();
			finalEndManager.QueueProecess();
		}
	}
}