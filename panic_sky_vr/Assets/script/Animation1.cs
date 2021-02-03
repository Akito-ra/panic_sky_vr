using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation1: MonoBehaviour {
    private Animator animator;
    public static int a; //stay -> walk
    public float time;

    private const string stay_walk = "stay-walk";
    private const string stay_ikaku = "stay-ikaku";
    private const string ikaku_walk = "ikaku-walk";
    private const string ikaku_stay = "ikaku-stay";
    private const string walk_ikaku = "walk-ikaku";
    public int s=0;

    // Use this for initialization
    void Start ()
    {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(a == 0)
        {

            animator.SetBool(stay_walk, true);
            s = a;

        }
        else
        {
            animator.SetBool(stay_walk, false);
        }

        if(a==1)
        {
            animator.SetBool(stay_ikaku, true);
            s = a;
            time += Time.deltaTime;
            if (time >= 2)
            {
                time = 0;
                a = 2;
                s = a;
            }
        }
        else
        {
            animator.SetBool(stay_ikaku, false);
        }

        if(a == 2)
        {
            animator.SetTrigger(ikaku_walk);
        }

        if (a == 3)
        {
            animator.SetBool(ikaku_stay, true);
        }
        else
        {
            animator.SetBool(ikaku_stay, false);
        }
        
        if(a == 4)
        {
            animator.SetBool(walk_ikaku, true);
            s = a;
            time += Time.deltaTime;
            if (time >= 2)
            {
                time = 0;
                a = 2;
            }
        }
        else
        {
            animator.SetBool(walk_ikaku, false);
        }
	}
}
