﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform goal;
    public NavMeshAgent agent; 
    void Start () {
	   agent = GetComponent<NavMeshAgent>();
	    
    }
    // Update is called once per frame
    void Update()
    {
	    agent.SetDestination(goal.position);  
    }
}
