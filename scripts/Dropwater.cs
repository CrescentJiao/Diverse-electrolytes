using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dropwater : MonoBehaviour {
    public Slider slider;
    private Animation ani;
    float curvalue;
    // Use this for initialization
    void Start () {
        ani = GetComponent<Animation>();
        curvalue = slider.value;
    }
	
	// Update is called once per frame
	void Update () {
		if(curvalue !=slider.value )
        {
            AnimationState state = ani["dropwater"];
            ani.Play("dropwater");
            //print("11");
            state.wrapMode = WrapMode.Once;
            curvalue = slider.value;
        }
        else
        {
            this.transform.position = new Vector3(0, 3.30f, -2.42f);
        }
	}
}
