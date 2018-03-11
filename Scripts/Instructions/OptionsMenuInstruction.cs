using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DSA.Extensions.Base;

[CreateAssetMenu(fileName = "OptionsMenuInstruction", menuName = "MenuInstruction/OptionsMenuInstruction")]
[System.Serializable]
public class OptionsMenuInstruction : MenuInstruction
{
	public override ExtensionEnum.Extension Extension { get { return ExtensionEnum.Extension.Options; } }

	public override void Use()
	{
		throw new NotImplementedException();
	}
}
