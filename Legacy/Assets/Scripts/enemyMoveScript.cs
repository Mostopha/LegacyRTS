﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyMoveScript : MonoBehaviour {

    public float distanceAway;
    public Transform thisObject;
    public Transform target;
    private NavMeshAgent navComponent;

 

    // Use this for initialization
    void Start () {

      
        navComponent = this.gameObject.GetComponent<NavMeshAgent>();
		
	}
	
	// Update is called once per frame
	void Update () {
        //float dist = Vector3.Distance(target.position, transform.position);

        if (target)
        {
            navComponent.SetDestination(target.position);
        }
        else
        {
            if (target = null)
            {
                target = this.gameObject.GetComponent<Transform>();
                //target = GameObject.FindGameObjectWithTag("chosen").transform;

            }
            else
            {
                target = GameObject.FindGameObjectWithTag("chosen").transform;
                float dist = Vector3.Distance(target.position, transform.position);
            }
        }
    }
}
