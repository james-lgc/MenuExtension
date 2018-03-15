using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DSA.Extensions.Base;

[CreateAssetMenu(fileName = "LoadMenuInstruction", menuName = "MenuInstruction/LoadMenuInstruction")]
[System.Serializable]
public class LoadMenuInstruction : MenuInstruction, ISendable
{
	public override ExtensionEnum Extension { get { return ExtensionEnum.Load; } }
}
