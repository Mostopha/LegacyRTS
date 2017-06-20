using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimapJumpCamera : MonoBehaviour {

    Vector3 newCameraPosition;
    Vector3 viewPortPosiion;
    float mainCameraHeight;

    public float cameraXOffset;
    public float cameraZOffset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetMouseButtonDown(0))
        {
            viewPortPosiion = GetComponent<Camera>().ScreenToViewportPoint(Input.mousePosition);
            Ray ray = GetComponent<Camera>().ViewportPointToRay(viewPortPosiion);
            RaycastHit hit;

            if(Physics.Raycast(ray,out hit))
            {
                newCameraPosition = hit.point;
                mainCameraHeight = Camera.main.transform.position.y;
                Camera.main.transform.position = new Vector3(newCameraPosition.x, mainCameraHeight, newCameraPosition.z);
            }


        }

        if (Input.GetKey(KeyCode.Space))
        {
            newCameraPosition = GameObject.FindGameObjectWithTag("chosen").transform.position;
            mainCameraHeight = Camera.main.transform.position.y;
            Camera.main.transform.position = new Vector3(newCameraPosition.x, mainCameraHeight, newCameraPosition.z-cameraZOffset);

        }
	}
}
