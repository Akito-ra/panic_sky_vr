using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_to_Title : MonoBehaviour
{
    float timecount = 20.0f; //次のシーンに転移するまでの時間
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Invoke("GoTitle", timecount); //Invoke("実行する関数名", ラグ)
    }

    void GoTitle()
    {
        SceneManager.LoadScene("Opening");
    }
}
