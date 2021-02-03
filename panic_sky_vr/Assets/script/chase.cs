using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase : MonoBehaviour {
    public static int i;
	// Use this for initialization
	void Start () {
        i = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("ExcludeTeleport"))
        {
            Debug.Log("a");
            i = 1;
            Animation1.a = 1;
        }
    }
}
