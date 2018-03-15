using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DSA.Extensions.Base;

[CreateAssetMenu(fileName = "AudioMenuInstruction", menuName = "MenuInstruction/AudioMenuInstruction")]
[System.Serializable]
public class AudioMenuInstruction : MenuInstruction
{
	public override ExtensionEnum Extension { get { return ExtensionEnum.Audio; } }
}
