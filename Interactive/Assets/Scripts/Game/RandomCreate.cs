using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCreate : MonoBehaviour {
    private int Create;
    
    private Vector3 ForCreatePos1;
    private Vector3 ForCreatePos2;
    private Vector3 ForCreatePos3;
    // Use this for initialization
    void Start () {
        ForCreatePos1 = new Vector3(10,3.5f,0);
        ForCreatePos2 = new Vector3(10, 0, 0);
        ForCreatePos3 = new Vector3(10, -3.5f, 0);

    }
	
	// Update is called once per frame
	void Update () {
        Create = Random.Range(1, 3000);
        if(Create == 7)
        {
            GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_01")) as GameObject;
            CreateForQuickButton.transform.position = ForCreatePos1;
        }
        if (Create == 77)
        {
            GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_01")) as GameObject;
            CreateForQuickButton.transform.position = ForCreatePos2;
        }
        if (Create == 777)
        {
            GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_01")) as GameObject;
            CreateForQuickButton.transform.position = ForCreatePos3;
        }
    }
}
