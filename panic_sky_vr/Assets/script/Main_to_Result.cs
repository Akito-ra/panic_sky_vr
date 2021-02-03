using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_to_Result : MonoBehaviour
{
    public void GameClear()
    {
        SceneManager.LoadScene("Ending_Clear");
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Ending_Over");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
