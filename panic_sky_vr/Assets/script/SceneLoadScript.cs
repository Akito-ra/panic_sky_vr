using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //シーンを読み込む際に必要

public class SceneLoadScript : MonoBehaviour
{
    public GameObject load;
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Respawn") //Respawnとタグ付けされたオブジェクト(今回は右コントローラー)に触れたとき
        {
            Debug.Log("load");
            load.GetComponent<sceneload>().enabled = true;
        }
    }

	// Use this for initialization
	void Start () {
        Debug.Log("b");
	}
	
	// Update is called once per frame
	void Update ()
    {
        
    }
}
