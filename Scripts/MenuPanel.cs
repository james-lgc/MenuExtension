using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UISystem
{
	public class MenuPanel : MonoBehaviour
	{

		[SerializeField] private bool isCancelable;
		public bool IsCancelable { get { return isCancelable; } }
		[SerializeField] private Button[] buttons;

	}
}
