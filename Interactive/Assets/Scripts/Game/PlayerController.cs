using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Vector2 PlayerinitPos;
    private float deltaY;
    static public int Score;
    public GameObject S1,S2,S3,B1;
    // Use this for initialization
    void Start () {
        PlayerinitPos = new Vector2(-10, 0);
        transform.position = PlayerinitPos;
        Score = 0;

    }
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x < -7f)
        {
            transform.position += new Vector3(0.05f, 0, 0);
        }
        if(transform.position.x >= -7f)
        {
            StartGame();
        }
        if(transform.position.y >= 4.3f)
        {
            transform.position = new Vector2(-7f,4.3f);
        }
        if (transform.position.y <= -4.3f)
        {
            transform.position = new Vector2(-7f, -4.3f);
        }
        if(Score >= 10)
        {
            S1.SetActive(false);
            S2.SetActive(false);
            S3.SetActive(false);
            B1.SetActive(true);
            this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Images/Player_02");
            //Time.timeScale = 0;
        }
    }

    void StartGame()
    {
        transform.position = new Vector2(-7f, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        /*if (Input.touchCount > 0) //此為手機版本
        {
            Touch touch = Input.GetTouch(0);

            // Handle finger movements based on touch phase.
            switch (touch.phase)
            {
                // Record initial touch position.
                case TouchPhase.Began:
                    deltaY = touch.position.y - transform.position.y;
                    break;

                // Determine direction by comparing the current touch position with the initial one.
                case TouchPhase.Moved:
                    transform.position = new Vector3(-4.5f, (touch.position.y - deltaY)/100,0);
                    break;

                // Report that a direction has been chosen when the finger is lifted.
                case TouchPhase.Ended:
                    
                    break;
            }
        }*/
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "QuickButton")
        {
            Destroy(collision.gameObject);
            Score ++;
        }
            
    }
}
