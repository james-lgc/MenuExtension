using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DSA.Extensions.Base;

[CreateAssetMenu(fileName = "ResumeMenuInstruction", menuName = "MenuInstruction/ResumeMenuInstruction")]
[System.Serializable]
public class ResumeMenuInstruction : MenuInstruction, ISendable
{
	public override ExtensionEnum Extension { get { return ExtensionEnum.GamePlay; } }
}
