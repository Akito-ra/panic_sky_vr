using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LimitTime : MonoBehaviour
{
    GameObject refObj;
    GameObject limitTimeUI;
    float time = 10.0f;

	// Use this for initialization
	void Start ()
    {
        this.limitTimeUI = GameObject.Find("Text");
        refObj = GameObject.Find("SceneLoadSystem");
    }
	
	// Update is called once per frame
	void Update ()
    {
        this.time -= Time.deltaTime;
        if (this.time < 0)
        {
            //this.limitTimeUI.GetComponent<Text>().text = "終了";
            //SceneManager.LoadScene("Ending_Clear"); //移動したいシーン
            Main_to_Result m2 = refObj.GetComponent<Main_to_Result>();
            m2.GameOver();
        }
        else
        {
            this.limitTimeUI.GetComponent<Text>().text = this.time.ToString("F1");
        }
	}
}
