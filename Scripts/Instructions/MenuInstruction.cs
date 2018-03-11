using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DSA.Extensions.Base;

public abstract class MenuInstruction : ExtendedScriptableObject, ISendable, IUseable
{
	[SerializeField] private string instructionName;
	public string InstructionName { get { return instructionName; } }

	private int id;
	public int ID { get { return id; } }

	public Action SendAction { get; set; }

	public void SetID(int sentID)
	{
		id = sentID;
	}

	public virtual void Use()
	{
		if (!GetIsExtensionLoaded() || SendAction == null) { return; }
		SendAction();
	}
}
