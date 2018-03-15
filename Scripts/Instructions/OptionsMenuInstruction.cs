using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DSA.Extensions.Base;

[CreateAssetMenu(fileName = "OptionsMenuInstruction", menuName = "MenuInstruction/OptionsMenuInstruction")]
[System.Serializable]
public class OptionsMenuInstruction : MenuInstruction
{
	public override ExtensionEnum Extension { get { return ExtensionEnum.Options; } }

	public override void Use()
	{
		throw new NotImplementedException();
	}
}
