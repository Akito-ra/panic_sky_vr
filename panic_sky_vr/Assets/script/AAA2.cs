using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAA2 : MonoBehaviour {
    public Transform target; //プレイヤーの位置
    static Vector3 pos;
    UnityEngine.AI.NavMeshAgent agent;
    public int  state;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        state = 1;
    }
    void Update()
    {

        if (state == 1)
        {
            pos = target.position;
            agent.SetDestination(pos);
        }
    }  
}
