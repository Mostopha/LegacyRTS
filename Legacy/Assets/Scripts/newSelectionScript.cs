using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class newSelectionScript : MonoBehaviour {

    public Camera cam;
    public NavMeshAgent navMeshAgent;
    private Collider previousUnit;

    private NavMeshAgent[] navMeshArrays;

    // Use this for initialization
    void Start()
    {
        navMeshArrays = new NavMeshAgent[5];

        cam = Camera.main;


        //navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent = null;

        

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                //navMeshAgent.SetDestination(hit.point);

                for (int i = 0; i < navMeshArrays.Length; i++)
                {
                   navMeshArrays[i].SetDestination(hit.point);
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            //previousUnit.tag = "Player";
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Player")
                {
                    if (previousUnit != null)
                    {
                        previousUnit.tag = "Player";
                    }

                    hit.collider.tag = "chosen";
                    //navMeshAgent = hit.collider.GetComponent<NavMeshAgent>();

                    navMeshArrays[0] = hit.collider.GetComponent<NavMeshAgent>();

                    previousUnit = hit.collider;
                    Debug.Log(previousUnit.name);


                }
            }
        }
    }
}
