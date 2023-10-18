using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enamy : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent agent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            agent.SetDestination(target.position);
        }
    }
}
