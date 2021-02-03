using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour {
    public GameObject camerarig;
    public GameObject target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("a");
            //Transform get = target.transform;
            //camerarig.transform.position = get.position;
			camerarig.transform.position =new Vector3(0,0,0);
        }
    }
}
