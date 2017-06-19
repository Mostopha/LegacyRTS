using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScroll : MonoBehaviour {

    public int scrollDistance = 10;
    public float scrollSpeed = 5;

    public int cameraHeight = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float mousePosX = Input.mousePosition.x;
        float mousePosY = Input.mousePosition.y;
        
        
        if (mousePosX < scrollDistance)
        {
            transform.Translate(Vector3.right * -scrollSpeed * Time.deltaTime);
        }

        if (mousePosX >= Screen.width - scrollDistance)
        {
            transform.Translate(Vector3.right * scrollSpeed * Time.deltaTime);
        }

        if (mousePosY < scrollDistance)
        {
            transform.Translate(transform.forward * -scrollSpeed * Time.deltaTime);
        }

        if (mousePosY >= Screen.height - scrollDistance)
        {
            transform.Translate(transform.forward * scrollSpeed * Time.deltaTime);
        }

        if(Input.GetAxis("Mouse ScrollWheel")> 0 && cameraHeight <= 7)
        {
            cameraHeight++;
            transform.Translate(0, 1, 0);
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0 && cameraHeight >= 0)
        {
            cameraHeight--;
            transform.Translate(0, -1, 0);
        }
    }
}
