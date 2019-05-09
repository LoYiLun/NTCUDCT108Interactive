using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RandomCreate : MonoBehaviour {
    private int CreateIntForQuickButton;
    private int CreateIntForObstacle;
    private int QuickButtonType;

    private Vector3 ForCreatePos1;// 1~5是給快捷鍵
    private Vector3 ForCreatePos2;
    private Vector3 ForCreatePos3;
    private Vector3 ForCreatePos4;
    private Vector3 ForCreatePos5;
    private Vector3 ForCreatePos6;// 6~7是給障礙物
    private Vector3 ForCreatePos7;
    // Use this for initialization
    void Start () {
        ForCreatePos1 = new Vector3(10,3.5f,0);
        ForCreatePos2 = new Vector3(10, 0, 0);
        ForCreatePos3 = new Vector3(10, -3.5f, 0);
        ForCreatePos4 = new Vector3(10, 2.25f, 0);
        ForCreatePos5 = new Vector3(10, -2.25f, 0);
        ForCreatePos6 = new Vector3(12,-2.6f,0);
        ForCreatePos7 = new Vector3(12,3.3f,0);
        InvokeRepeating("CreateQuickButton", 2, 1);
        InvokeRepeating("CreateObstacle", 2, 0.5f);
    }
	
	// Update is called once per frame
	void Update () {

    }

    void CreateQuickButton()
    {
        CreateIntForQuickButton = Random.Range(1, 30);
        QuickButtonType = Random.Range(1, 100);
        if (CreateIntForQuickButton == 1)
        {
            switch (QuickButtonType % 5)
            {
                case 1:
                    {
                        GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_-")) as GameObject;
                        CreateForQuickButton.transform.position = ForCreatePos1;
                        break;
                    }
                case 2:
                    {
                        GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_+")) as GameObject;
                        CreateForQuickButton.transform.position = ForCreatePos1;
                        break;
                    }
                case 3:
                    {
                        GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_c")) as GameObject;
                        CreateForQuickButton.transform.position = ForCreatePos1;
                        break;
                    }
                case 4:
                    {
                        GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_x")) as GameObject;
                        CreateForQuickButton.transform.position = ForCreatePos1;
                        break;
                    }
            }
            if(QuickButtonType == 50)
            {
                GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_s")) as GameObject;
                CreateForQuickButton.transform.position = ForCreatePos1;
            }
            CreateIntForQuickButton = 0;
        }
        else if (CreateIntForQuickButton == 2)
        {
            switch (QuickButtonType % 5)
            {
                case 1:
                    {
                        GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_-")) as GameObject;
                        CreateForQuickButton.transform.position = ForCreatePos2;
                        break;
                    }
                case 2:
                    {
                        GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_+")) as GameObject;
                        CreateForQuickButton.transform.position = ForCreatePos2;
                        break;
                    }
                case 3:
                    {
                        GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_c")) as GameObject;
                        CreateForQuickButton.transform.position = ForCreatePos2;
                        break;
                    }
                case 4:
                    {
                        GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_x")) as GameObject;
                        CreateForQuickButton.transform.position = ForCreatePos2;
                        break;
                    }
            }
            if (QuickButtonType == 50)
            {
                GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_s")) as GameObject;
                CreateForQuickButton.transform.position = ForCreatePos2;
            }
            CreateIntForQuickButton = 0;
        }
        else if(CreateIntForQuickButton == 3)
        {
            switch (QuickButtonType % 5)
            {
                case 1:
                    {
                        GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_-")) as GameObject;
                        CreateForQuickButton.transform.position = ForCreatePos3;
                        break;
                    }
                case 2:
                    {
                        GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_+")) as GameObject;
                        CreateForQuickButton.transform.position = ForCreatePos3;
                        break;
                    }
                case 3:
                    {
                        GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_c")) as GameObject;
                        CreateForQuickButton.transform.position = ForCreatePos3;
                        break;
                    }
                case 4:
                    {
                        GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_x")) as GameObject;
                        CreateForQuickButton.transform.position = ForCreatePos3;
                        break;
                    }
            }
            if (QuickButtonType == 50)
            {
                GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_s")) as GameObject;
                CreateForQuickButton.transform.position = ForCreatePos3;
            }
            CreateIntForQuickButton = 0;
        }
        else if (CreateIntForQuickButton == 4)
        {
            switch (QuickButtonType % 5)
            {
                case 1:
                    {
                        GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_-")) as GameObject;
                        CreateForQuickButton.transform.position = ForCreatePos4;
                        break;
                    }
                case 2:
                    {
                        GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_+")) as GameObject;
                        CreateForQuickButton.transform.position = ForCreatePos4;
                        break;
                    }
                case 3:
                    {
                        GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_c")) as GameObject;
                        CreateForQuickButton.transform.position = ForCreatePos4;
                        break;
                    }
                case 4:
                    {
                        GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_x")) as GameObject;
                        CreateForQuickButton.transform.position = ForCreatePos4;
                        break;
                    }
            }
            if (QuickButtonType == 50)
            {
                GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_s")) as GameObject;
                CreateForQuickButton.transform.position = ForCreatePos4;
            }
            CreateIntForQuickButton = 0;
        }
        else if (CreateIntForQuickButton == 5)
        {
            switch (QuickButtonType % 5)
            {
                case 1:
                    {
                        GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_-")) as GameObject;
                        CreateForQuickButton.transform.position = ForCreatePos5;
                        break;
                    }
                case 2:
                    {
                        GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_+")) as GameObject;
                        CreateForQuickButton.transform.position = ForCreatePos5;
                        break;
                    }
                case 3:
                    {
                        GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_c")) as GameObject;
                        CreateForQuickButton.transform.position = ForCreatePos5;
                        break;
                    }
                case 4:
                    {
                        GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_x")) as GameObject;
                        CreateForQuickButton.transform.position = ForCreatePos5;
                        break;
                    }
            }
            if (QuickButtonType == 50)
            {
                GameObject CreateForQuickButton = Instantiate(Resources.Load("Prefabs/QuickButton_s")) as GameObject;
                CreateForQuickButton.transform.position = ForCreatePos5;
            }
            CreateIntForQuickButton = 0;
        }
        /*else
        {
            CancelInvoke("CreateQuickButton");
        }*/
    }

    void CreateObstacle()
    {
        CreateIntForObstacle = Random.Range(1, 5);
        if(CreateIntForObstacle  == 1)
        {
            GameObject CreateForObstacle = Instantiate(Resources.Load("Prefabs/障礙物_塔")) as GameObject;
            CreateForObstacle.transform.position = ForCreatePos6;
            CreateIntForObstacle = 0;
        }
        else if (CreateIntForObstacle == 2)
        {
            GameObject CreateForObstacle = Instantiate(Resources.Load("Prefabs/障礙物_船錨")) as GameObject;
            CreateForObstacle.transform.position = ForCreatePos7;
            CreateIntForObstacle = 0;
        }
        /*else
        {
            CancelInvoke("CreateObstacle");
        }*/
    }
}
