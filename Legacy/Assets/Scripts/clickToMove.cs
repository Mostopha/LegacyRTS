using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class clickToMove : MonoBehaviour {

    public Camera cam;
    public NavMeshAgent navMeshAgent;

	// Use this for initialization
	void Start () {
        cam = Camera.main;


        //navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent = null;

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                navMeshAgent.SetDestination(hit.point);
            }
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Player")
                {
                    navMeshAgent = hit.collider.GetComponent<NavMeshAgent>();
                }
            }
        }
	}
}
