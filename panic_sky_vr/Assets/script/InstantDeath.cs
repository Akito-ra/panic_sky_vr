using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstantDeath : MonoBehaviour
{
    GameObject refObj;

    // Use this for initialization
    void Start ()
    {
        refObj = GameObject.Find("SceneLoadSystem");
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Spider")
        {
            Debug.Log("b");
            Main_to_Result m1 = refObj.GetComponent<Main_to_Result>();
            m1.GameOver();
            SceneManager.LoadScene("Ending_Over");
        }
    }
}
