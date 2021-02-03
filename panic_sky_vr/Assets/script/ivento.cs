using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ivento : MonoBehaviour {
    public int i;
    public static int n;
    public float time;
    public GameObject fire;
	// Use this for initialization
	void Start () {
        i = 2;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerStay(Collider hit)
    {

        if (hit.CompareTag("Player"))
        {
            time += Time.deltaTime;
            if (time >= 3)
            {
                Debug.Log("a");
                n = 0;
                GameObject.Find("idou").SendMessage("ibee", i);
                Instantiate(fire, this.transform.position, Quaternion.identity);
                time = 0;
            }
        }
        
    }
}
