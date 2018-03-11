using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UISystem;
using System;
using DSA.Extensions.Base;

public class MenuButton : UIButtonBase, ISettable<MenuInstruction>, ISendable<MenuInstruction>
{
	public override ExtensionEnum.Extension Extension { get { return ExtensionEnum.Extension.Menu; } }

	public Action<MenuInstruction> SendAction { get; set; }

	[SerializeField] private MenuInstruction menuInstruction;

	protected override void Use()
	{
		try
		{
			SendAction(menuInstruction);
		}
		catch (System.Exception e) { Debug.Log(e.ToString()); }
	}

	public void Set(MenuInstruction sentItem)
	{
		menuInstruction = sentItem;
		SetText(menuInstruction.InstructionName);
	}
}
