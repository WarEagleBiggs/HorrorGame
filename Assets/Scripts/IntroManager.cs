using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
	public GameObject Quote1;
	public GameObject CineStuff;
	
	
    // Start is called before the first frame update
    void Start()
    {
	    StartCoroutine(QuoteRun());
    }

    // Update is called once per frame
    void Update()
    {
    }
    
	public IEnumerator QuoteRun()
	{
		yield return new WaitForSeconds(34);
		SceneManager.LoadScene(2);
	}
}
