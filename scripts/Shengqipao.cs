using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shengqipao : MonoBehaviour {
    public Slider slider;
    ParticleSystem qipaoParticleSystem;
    float cvalue;
    float y;
    // Use this for initialization
    void Start () {
        cvalue = slider.value;
        y = 2.18f;
	}
	
	// Update is called once per frame
	void Update () {
       qipaoParticleSystem = this.gameObject.GetComponent<ParticleSystem>();
        // GetComponent<ParticleSystem>().emission.rateOverTime = slider.value ;
        ParticleSystem.EmissionModule emission = qipaoParticleSystem.emission;
        
        if(cvalue > slider.value)
        {
            y = y - 0.005f;
            this.transform.position  = new Vector3(-0.27f, y, -2.09f);
            cvalue = slider.value;
        }
        else if (cvalue < slider.value)
        {
            y = y + 0.005f;
            this.transform.position = new Vector3(-0.27f, y, -2.09f);
            cvalue = slider.value;
        }
        else
        {
            this.transform.position = new Vector3(-0.27f, y, -2.09f);
            cvalue = slider.value;
        }
        if (slider.value == 0)
        {
            y = 2.18f;
            this.transform.position = new Vector3(-0.27f, y, -2.09f);
            cvalue = slider.value;
            emission.rateOverTime = 0;
        }else  if (slider.value>0 && slider.value <= 30)
        {
            emission.rateOverTime = slider.value;
        }
        else if(slider.value>30&& slider.value<100)
        {
            emission.rateOverTime = 30;
        }
    }
}
