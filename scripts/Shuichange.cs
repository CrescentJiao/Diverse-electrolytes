using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shuichange : MonoBehaviour {
    public Slider slider;
    float cvalue;
    float  y;
    // Use this for initialization
    void Start () {
        cvalue = slider.value;
        y = 0.8f;
	}
	
	// Update is called once per frame
	void Update () {
        if(slider.value ==0)
        {
            y = 0.8f;
            this.transform.localScale = new Vector3(1.0f, y, 1.0f);
            cvalue = slider.value;
        }
        if (cvalue > slider.value)
        {
            y=y-0.0041f;
            this.transform.localScale = new Vector3(1.0f, y, 1.0f);
            cvalue = slider.value;
        }
        else if(cvalue <slider.value)
        {
            y = y + 0.0041f;
            this.transform.localScale=new Vector3 (1.0f,y ,1.0f) ;
            cvalue = slider.value;
        }
        else
        {
            this.transform.localScale = new Vector3(1.0f, y, 1.0f);
            cvalue = slider.value;
        }
       

	}
}
