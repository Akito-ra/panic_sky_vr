using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation3 : MonoBehaviour
{
    Animator animator;
    static int c;
    bool ikaku;
	// Use this for initialization
	void Start ()
    {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (c == 1)
        {
            ikaku = true;
            animator.SetBool("Ikaku", true);
        }
    }
}
