using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DSA.Extensions.Base;

[CreateAssetMenu(fileName = "ExitMenuInstruction", menuName = "MenuInstruction/ExitMenuInstruction")]
[System.Serializable]
public class ExitMenuInstruction : MenuInstruction
{
	public override ExtensionEnum Extension { get { return ExtensionEnum.Menu; } }

	public override void Use()
	{
		throw new NotImplementedException();
	}
}
