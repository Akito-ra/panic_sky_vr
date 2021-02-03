using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop : MonoBehaviour {
    public GameObject[] obj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "GameController")
        {
            for (int i = 0; i < 3; i++)
            {
                Instantiate(obj[i], this.transform.position, Quaternion.identity);
                Animation1.a = 4;
                Destroy(gameObject);
            }
        }
    }
}
