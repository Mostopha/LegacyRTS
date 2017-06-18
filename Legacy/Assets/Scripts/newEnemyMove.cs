using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class newEnemyMove : MonoBehaviour {

    public Transform target;
    public Transform self;
    private NavMeshAgent navigator;
	// Use this for initialization
	void Start () {
        self = this.transform;
        navigator = this.gameObject.GetComponent<NavMeshAgent>();
     
	}
	
	// Update is called once per frame
	void Update () {

        if (GameObject.FindGameObjectWithTag("chosen") != null)
        {
            target = GameObject.FindGameObjectWithTag("chosen").transform;

        }
        else
        { target = self; }

        navigator.SetDestination(target.position);




    }
}
