using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation2 : MonoBehaviour
{
    private Animator animator;
    static int b;
	// Use this for initialization
	void Start ()
    {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (b == 1)
        {
            animator.SetBool("stay-ikaku", true);
        }
        else
        {
            animator.SetBool("stay-ikaku", false);
        }
	}
}
