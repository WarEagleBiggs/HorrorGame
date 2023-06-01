using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PixelScreen : MonoBehaviour
{
	public GameObject Screen;

	public GameObject PauseMenu;

	public DoorDetect m_Detect;
    // Start is called before the first frame update
    void Start()
    {
	    Screen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
	    if (Input.GetKeyDown(KeyCode.Escape))
	    {
		    PauseMenu.SetActive(true);
	    }
    }


    public void Return()
    {
	    m_Detect.m_move.enabled = true;
	    m_Detect.m_look.enabled = true;
	    Cursor.visible = false;
	    Cursor.lockState = CursorLockMode.Locked;
	    PauseMenu.SetActive(false);
    }

    public void Menu()
    {
	    SceneManager.LoadScene(1);
    }

    public void Quit()
    {
	    Application.Quit();
    }
}
