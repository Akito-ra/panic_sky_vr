using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSpawn : MonoBehaviour {

	public static int spawnflg = 0;

	public GameObject[] spawnPoint;
	public GameObject dethpoint;
	public GameObject player;

	private float cnt = 0;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		Debug.Log ("Enter");
		if (col.gameObject.tag == "respon") {
			Debug.Log ("respon");
			for (int i = 1; i < spawnPoint.Length; i++) {
				if (col.gameObject.name == spawnPoint [i].gameObject.name) {
					if (i > spawnflg) {
						spawnflg = i;
						Debug.Log ("spawnflg = " + spawnflg);
					}
				}
			}
		}
	}


    private void OnTriggerStay(Collider col)
    {
        {
            Debug.Log("derstay");
            if (col.gameObject.name == dethpoint.gameObject.name)
            {
                cnt += Time.deltaTime;
                Debug.Log("cnt =" + cnt);
                if (cnt >= 1)
                {
                    cnt = 0;
                    player.transform.position = spawnPoint[spawnflg].transform.position;
                }
            }
        }
    }
}
