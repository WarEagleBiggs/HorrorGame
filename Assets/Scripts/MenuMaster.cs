using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMaster : MonoBehaviour
{
	
	public void PlayGame()
	{
		SceneManager.LoadScene(3);
	}
	public void QuitGame()
	{
		Application.Quit();
	}
}
