using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BgsIntro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
	    StartCoroutine(LoadMenu());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	public IEnumerator LoadMenu()
	{
		yield return new WaitForSeconds(8);
		SceneManager.LoadScene(1);
	}
}
