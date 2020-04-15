using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleOne : MonoBehaviour
{
    public Transform target;

   UnityEngine.AI.NavMeshAgent agent;
    
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetCompoent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }
}
