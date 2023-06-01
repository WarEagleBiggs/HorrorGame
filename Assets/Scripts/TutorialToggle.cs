using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialToggle : MonoBehaviour
{
    public GameObject smallTutorial;
    public GameObject largeTutorial;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (smallTutorial.activeSelf == true)
            {
                smallTutorial.SetActive((false));
                largeTutorial.SetActive(true);
            }
            else
            {
                smallTutorial.SetActive((true));
                largeTutorial.SetActive(false);
            }
        }
    }
}
