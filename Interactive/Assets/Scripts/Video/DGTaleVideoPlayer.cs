using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class DGTaleVideoPlayer : MonoBehaviour {
    public GameObject White;
    public GameObject Black;
    public GameObject DGTaleVideo;
    private bool TimeToBlack;
    // Use this for initialization
    void Start () {
        White.GetComponent<Image>().color = new Color(255, 255, 255, 1);
        Black.GetComponent<Image>().color = new Color(0,0,0, 0);
        Invoke("TurnBlack", 69);
        Invoke("StopVideo",71);
        TimeToBlack = false;

    }
	
	// Update is called once per frame
	void Update () {
        White.GetComponent<Image>().color -= new Color(0, 0, 0, 0.01f);
        if (TimeToBlack)
        {
            Black.GetComponent<Image>().color += new Color(0, 0, 0, 0.01f);
        }
    }
    void TurnBlack()
    {
        //DGTaleVideo.GetComponent<VideoPlayer>().Stop();
        TimeToBlack = true;
    }
    void StopVideo()
    {
        SceneManager.LoadScene("Menu");
    }
}
