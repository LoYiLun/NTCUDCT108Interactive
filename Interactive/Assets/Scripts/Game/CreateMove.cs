using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.tag == "QuickButton")
        {
            transform.position -= new Vector3(0.05f, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(0.1f, 0, 0);
        }
        
        if(transform.position.x < -15 || PlayerController.Score >= 10 )
        {
            Destroy(gameObject);
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "QuickButton" && (transform.tag == "QuickButton" || transform.tag == "Obstacle"))
        {
            Destroy(collision.gameObject);
        }
        else if (collision.transform.tag == "Obstacle" && transform.tag == "Obstacle")
        {
            Destroy(collision.gameObject);
        }
    }
}
