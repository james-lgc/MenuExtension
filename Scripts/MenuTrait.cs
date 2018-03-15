using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using DSA.Extensions.Base;

[RequireComponent(typeof(TraitedMonoBehaviour))]
[System.Serializable]
public abstract class MenuTrait : TraitBase
{
	public override ExtensionEnum Extension { get { return ExtensionEnum.Menu; } }
}
