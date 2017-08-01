using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class clickToMove : MonoBehaviour {

    public Camera cam;
    public NavMeshAgent navMeshAgent;
    private Collider previousUnit;

    private bool UIHoverState;

    public NavMeshAgent[] navMeshArrays;

    // Use this for initialization
    void Start () {
        cam = Camera.main;


        //navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent = null;

       UIHoverState = UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject();

    }
	
	// Update is called once per frame
	void Update () {

        //Debug.Log(UIHoverState);

        Debug.Log("The mouse is hovering");

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
           
            

            //previousUnit.tag = "Player";
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            

            if(Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Player")
                {
                    if (previousUnit != null)
                    {
                        previousUnit.tag = "Player";
                    }

                    hit.collider.tag = "chosen";
                    navMeshAgent = hit.collider.GetComponent<NavMeshAgent>();
                    previousUnit = hit.collider;
                    Debug.Log(previousUnit.name);

                    
                }
            }
        }
	}
}
