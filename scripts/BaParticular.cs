using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaParticular : MonoBehaviour {
    public Slider slider;
    ParticleSystem BaParticleSystem;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        BaParticleSystem = this.gameObject.GetComponent<ParticleSystem>();
        // GetComponent<ParticleSystem>().emission.rateOverTime = slider.value ;
        ParticleSystem.EmissionModule emission = BaParticleSystem.emission;
        if (slider.value <= 50)
        {
            emission.rateOverTime = 46 - slider.value;
        }
        else
        {
            emission.rateOverTime = slider.value-50;
        }
    }
}
