using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectedScript : MonoBehaviour {

    public GameObject selectiorFeedback;

	// Use this for initialization
	void Start () {
        selectiorFeedback = GameObject.Find("selector");
	}
	
	// Update is called once per frame
	void Update () {
        if (this.tag == "chosen")
        {
            //selectiorFeedback.SetActive(true);

            transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            //selectiorFeedback.SetActive(false);

            transform.GetChild(0).gameObject.SetActive(false);
        }
	}
}
