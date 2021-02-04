using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CE : MonoBehaviour
{
    GameObject refObj;

    // Use this for initialization
    void Start ()
    {
        refObj = GameObject.Find("SceneLoadSystem");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Main_to_Result m1 = refObj.GetComponent<Main_to_Result>();
            m1.GameClear();
        }
    }


    // Update is called once per frame
    void Update () {
		
	}
}
