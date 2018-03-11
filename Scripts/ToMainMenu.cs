using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ToMainMenu : MonoBehaviour, ISubmitHandler {

	public void OnSubmit (BaseEventData eventData)
	{
		SceneManager.LoadScene("MainMenu");
	}

}
