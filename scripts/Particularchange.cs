using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Particularchange : MonoBehaviour {
    public Slider slider;
    ParticleSystem mParticleSystem;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        mParticleSystem = this.gameObject.GetComponent<ParticleSystem>();
        // GetComponent<ParticleSystem>().emission.rateOverTime = slider.value ;
        ParticleSystem.EmissionModule emission = mParticleSystem.emission;
        if (slider.value <= 50)
        {
         emission.rateOverTime = slider.value;
        }   else
        {
            emission.rateOverTime = 110 - slider.value;
        }
        



    }
   
}
