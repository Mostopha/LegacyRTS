using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFacingBillboard : MonoBehaviour {

    public Camera main;

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        {
            //transform.LookAt(main.transform);

            transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward,
            Camera.main.transform.rotation * Vector3.up);
        }
    }
}
