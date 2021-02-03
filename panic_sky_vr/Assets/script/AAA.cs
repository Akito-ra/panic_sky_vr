using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class AAA : MonoBehaviour
{

    public Transform target; //プレイヤーの位置
    public Transform pos0,a;
    public Transform[] ito;
    static Vector3 pos;
    NavMeshAgent agent;
    public int i,state;
    private float wtime;
    GameObject hand;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        i = 1;
        state = 0;
        wtime = 0.0f;

    }
    void Update()
    {
        /*if (state == 0)//自動徘徊
        {
            if (i == 1)
            {
                wtime += Time.deltaTime;
                pos = pos0.position;
                agent.SetDestination(pos);
                if (wtime >= 15.0f)
                {
                    i = 2;
                    wtime = 0.0f;
                    Debug.Log("1-2");
                }
            }
            if (i == 2)
            {
                wtime += Time.deltaTime;
                pos = pos1.position;
                agent.SetDestination(pos);
                Debug.Log("2");
                if (wtime >= 15.0f)
                {
                    i = 3;
                    wtime = 0.0f;
                    Debug.Log("2-3");
                }
            }
            if (i == 3)
            {
                wtime += Time.deltaTime;
                pos = pos2.position;
                agent.SetDestination(pos);
                Debug.Log("3");
                if (wtime >= 20.0f)
                {
                    i = 1;
                    wtime = 0.0f;
                    Debug.Log("3-1");
                }
            }
        }*/

        if(state == 1)
        {
            pos = target.position;
            agent.SetDestination(pos);
        }
        if (chase.i == 1)
        {
            state = 1;
            chase.i = 0;
        }
        if(state == 2)
        {
          
            wtime += Time.deltaTime;
            hand = GameObject.Find("syougaibutu(Clone)");
            pos0 = hand.transform;
            pos = pos0.position;//糸の座標
            agent.SetDestination(pos);
            Debug.Log("sent");
            if (wtime >= 10.0f)
            {
                state = 1;
                wtime = 0.0f;
                Debug.Log("ivent");
            }
        }

    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Player"))
        {
            if (state == 0)
            {
                state = 1;
            }
        }
        if(hit.CompareTag("stop"))
        {
            if (state == 1)
            {
                state = 2;
            }
        }
    }
    void ibee(int ibe1)//切られた糸からibe1=2を送る
    {
        state = ibe1;//2
        wtime = 0;
    }

    /*void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            state = 0;
        }
    }*/

}

