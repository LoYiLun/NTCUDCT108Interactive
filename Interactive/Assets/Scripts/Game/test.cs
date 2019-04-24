using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position -= new Vector3(0.05f, 0, 0);
        if(transform.position.x < -10 || PlayerController.Score >= 10 )
        {
            Destroy(gameObject);
        }
	}
}
