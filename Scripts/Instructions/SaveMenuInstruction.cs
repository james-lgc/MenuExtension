using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DSA.Extensions.Base;

[CreateAssetMenu(fileName = "SaveMenuInstruction", menuName = "MenuInstruction/SaveMenuInstruction")]
[System.Serializable]
public class SaveMenuInstruction : MenuInstruction, ISendable
{
	public override ExtensionEnum Extension { get { return ExtensionEnum.Save; } }

	public override void Use()
	{
		if (!GetIsExtensionLoaded() || SendAction == null) { return; }
		SendAction();
	}
}
