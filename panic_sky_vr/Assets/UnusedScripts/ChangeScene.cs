using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    IEnumerator LoadSceneAndWait()
    {
        float start = Time.realtimeSinceStartup;
        AsyncOperation ope = SceneManager.LoadSceneAsync("Opening");
        ope.allowSceneActivation = false;

        while (Time.realtimeSinceStartup - start < 1)
        {
            yield return null;
        }

        ope.allowSceneActivation = true;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
