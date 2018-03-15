using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DSA.Extensions.Base;

[CreateAssetMenu(fileName = "CycleMenuInstruction", menuName = "MenuInstruction/CycleMenuInstruction")]
[System.Serializable]
public class CycleMenuInstruction : MenuInstruction
{
	public override ExtensionEnum Extension { get { return ExtensionEnum.Menu; } }

	[SerializeField] private int holderIndex;
	public int HolderIndex { get { return holderIndex; } }
}
