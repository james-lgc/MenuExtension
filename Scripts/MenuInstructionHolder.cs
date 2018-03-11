using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MenuInstructionHolder
{
	private int id;
	public int ID { get { return id; } }
	[SerializeField] private string name;
	[SerializeField] private MenuInstruction[] menuInstructions;
	public MenuInstruction[] MenuInstructions { get { return menuInstructions; } }
	private int selectionIndex;
	public int SelectionIndex { get { return selectionIndex; } }

	public void SetID(int sentID)
	{
		id = sentID;
	}
	public void SetSelectionIndex(int sentIndex)
	{
		selectionIndex = sentIndex;
	}
}
