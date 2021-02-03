using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ivento6 : MonoBehaviour {
    public int i;
	// Use this for initialization
	void Start () {
        i = 2;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Player"))
        {
            Debug.Log("a");
            ivento.n = 6;
            GameObject.Find("idou").SendMessage("ibee", i);
        }
    }
}
