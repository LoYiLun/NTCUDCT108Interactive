using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    private Vector2 PlayerinitPos;
    private float deltaY;
    private bool BSD;
    static public int Hp;
    static public int Score;
    static public bool HitX;
    public GameObject S1,B1,life1,life2,life3;
    private AudioSource EatQuickButton, HitObstacle, ChangeType, FinalType;
    public GameObject White;
    public GameObject Music;
    // Use this for initialization
    void Start () {
        EatQuickButton = GameObject.Find("吃到快捷鍵").GetComponent<AudioSource>();
        HitObstacle = GameObject.Find("撞到障礙物").GetComponent<AudioSource>();
        ChangeType = GameObject.Find("變換型態").GetComponent<AudioSource>();
        FinalType = GameObject.Find("最終型態").GetComponent<AudioSource>();
        PlayerinitPos = new Vector2(-10, 0);
        transform.position = PlayerinitPos;
        Score = 0;
        Hp = 3;
        life1.SetActive(true);
        life2.SetActive(true);
        life3.SetActive(true);
        HitX = false;
        BSD = false;
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
        if(Score >= 10 || Hp == 0)
        {
            HitX = true;
            S1.SetActive(false);
            
            if(Score >= 10)
            {
                this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Images/Player_02");
                transform.position = Vector3.Lerp(transform.position, new Vector3(10,transform.position.y,0), 0.01f);
                White.SetActive(true);
                White.GetComponent<Image>().color += new Color(0, 0, 0, 0.01f);
                Music.GetComponent<AudioSource>().volume--;
                Invoke("PlayVideo", 1);
            }
            else if(Hp == 0)
            {
                B1.SetActive(true);
                life1.SetActive(false);
                life2.SetActive(false);
                life3.SetActive(false);
                Destroy(gameObject);
            }
                
            //Time.timeScale = 0;
        }
        switch (Hp)
        {
            case 1:
                {
                    life1.SetActive(true);
                    life2.SetActive(false);
                    life3.SetActive(false);
                    break;
                }
            case 2:
                {
                    life1.SetActive(true);
                    life2.SetActive(true);
                    life3.SetActive(false);
                    break;
                }
            case 3:
                {
                    life1.SetActive(true);
                    life2.SetActive(true);
                    life3.SetActive(true);
                    break;
                }
        }
        
    }

    void StartGame()
    {
        if(Score < 10)
        {
            
            if (Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, 0.2f, 0);
            }
            else if (Input.GetKey(KeyCode.DownArrow)|| Input.GetKey(KeyCode.S))
            {
                transform.position -= new Vector3(0, 0.2f, 0);
            }
            else if(Input.GetAxis("Mouse Y") < 0 || Input.GetAxis("Mouse Y") > 0)
            {
                transform.position = new Vector2(-7f, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            }
        }
            
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
            if(Score < 9)
            {
                EatQuickButton.Play();
            }
            else if (Score == 9)
            {
                FinalType.Play();
            }
            if (collision.gameObject.name == "QuickButton_x(Clone)")
            {
                HitX = true;
                Invoke("SetHitX", 1);
            }
            else if (collision.gameObject.name == "QuickButton_+(Clone)")
            {
                transform.localScale += new Vector3(0.05f,0.05f,0.05f);
            }
            else if (collision.gameObject.name == "QuickButton_-(Clone)")
            {
                transform.localScale -= new Vector3(0.05f, 0.05f, 0.05f);
            }
            else if (collision.gameObject.name == "QuickButton_s(Clone)")
            {
                Score = Score + 10;
                FinalType.Play();
            }
            else if (collision.gameObject.name == "QuickButton_c(Clone)")
            {
                BSD = true;
                Invoke("ButtonScoreDouble", 1);
            }
            Destroy(collision.gameObject);
            if (BSD)
            {
                Score = Score + 2;
            }
            else
            {
                Score++;
            }
            
        }
        if(collision.tag == "Obstacle")
        {
            HitObstacle.Play();
            Hp--;
        }
            
    }
    void SetHitX()
    {
        HitX = false;
    }
    void ButtonScoreDouble()
    {
        BSD = false;
    }
    void PlayVideo()
    {
        SceneManager.LoadScene("Video");
    }
}
