using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Toggleweiguanchange : MonoBehaviour {
    public Sprite sprite1;
    public Sprite sprite2;
    // Use this for initialization
    void Start () {
        Toggle toggleweiguan;
         toggleweiguan= this.GetComponent<Toggle>();
        toggleweiguan.onValueChanged.AddListener(Weiguanchange);

    }
    void Weiguanchange(bool ison)
    {
        if (ison==true)
        {
            this.GetComponentInChildren<Image>().sprite = sprite2;
        }
        else
        {
            this.GetComponentInChildren<Image>().sprite = sprite1;
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
