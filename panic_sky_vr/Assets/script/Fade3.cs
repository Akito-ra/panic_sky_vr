using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fade3 : MonoBehaviour
{
    [SerializeField]
    private Color fadeColor = Color.black; 
    private Color fadeColor_2 = Color.clear;
    [SerializeField]
    private float fadeTime = 1.5f;
    bool tf = true;
    float lag = 2.5f;
    GameObject refObj;
    GameObject[] tagObject;
    public static int c=0;
    
    // Use this for initialization
    void Start ()
    {
        refObj = GameObject.Find("SceneLoadSystem");
        Check("Hostage"); 
        Debug.Log(tagObject.Length);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hostage")
        {
            c++;
            Debug.Log("a");
            
            Destroy(other.gameObject, lag);

            if (c >= 3)
            {
                SteamVR_Fade.Start(fadeColor, fadeTime, tf); //フェードアウト
                tf = false;
                Invoke("fadeClear", lag); //fadeClear関数の実行をlagでずらす
            }
        }
    }

    void fadeClear()
    {
        Check("Hostage");
        if (tagObject.Length != 0)
        {
            Debug.Log(tagObject.Length);
            tf = true;
            SteamVR_Fade.Start(fadeColor_2, fadeTime, tf); //フェードイン
        }
    }

    void Check(string tagname) 
    {
        tagObject = GameObject.FindGameObjectsWithTag(tagname);
        //指定したtagのオブジェクトの個数が0になったら、シーン移動
        if (tagObject.Length == 0) 
        {
            Main_to_Result m2 = refObj.GetComponent<Main_to_Result>();
            m2.GameClear();
        }
    }
}
