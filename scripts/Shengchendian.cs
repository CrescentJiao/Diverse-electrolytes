using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shengchendian : MonoBehaviour {
   //private Animation chendian;
    public Slider slider;
   // public  Button BaOH2;
    float curvalue;
    // Use this for initialization
    void Start () {
       
        //chendian = GetComponent<Animation>();
     // BaOH2.GetComponent<Button>().onClick.AddListener(Changechendian);
        curvalue = slider.value;
        this.transform.localScale = new Vector3(0f, 0f, 0f);
    }
	
	// Update is called once per frame
	void Update () {
        if (curvalue != slider.value)
        {
            if(slider.value<=50)
            {
               this.transform.localScale = new Vector3(slider.value/33, slider.value /33, slider.value /33);
                curvalue = slider.value;
            }
            else if(slider.value>50)
            {
               this.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
                curvalue = slider.value;
            }
            //AnimationState state = chendian["chendian"];
            //AnimationState state= chendian["222"];
           // state.speed = 0.4f;
            //state.wrapMode = WrapMode.Once;
            
           // chendian.Play("chendian");
            //chendian.Play("222");
            //print(state.time);
            
        }
        else
        {
            curvalue = slider.value;
            //chendian.Stop ("chendian");
            // chendian.Stop("222");
            // this.GetComponentInChildren<MeshRenderer>.enabled = false;
        }
    }
    
}
