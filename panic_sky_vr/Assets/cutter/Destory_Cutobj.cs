﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory_Cutobj : MonoBehaviour {
    public float time;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if (time >= 2)
        {
            Destroy(gameObject);
        }
	}
}
