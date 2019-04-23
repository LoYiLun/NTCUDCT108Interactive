using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ForTouchImage : MonoBehaviour {
    private Image _this;
    private int set;
	// Use this for initialization
	void Start () {
        _this = this.GetComponent<Image>();
        set = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if(_this.color.a >= 0.3f&& set == 0)
        {
            _this.color -= new Color(0,0,0,0.005f);
        }
        else 
        {
            set = 1;
            _this.color += new Color(0, 0, 0, 0.005f);
            if (_this.color.a >= 1)
                set = 0;
        }
	}
}
