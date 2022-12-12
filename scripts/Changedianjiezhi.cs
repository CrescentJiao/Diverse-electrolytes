using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SpringFramework22.UI;
using SpringFramework44.UI;
using System;

public class Changedianjiezhi : MonoBehaviour {
    public GameObject Parch3;
    public GameObject ParBa;
    public GameObject ParNH;
    public GameObject chendian;
    public GameObject qipao;
    public Slider slider1;
    Toggle toggle;
    Toggle toggleweiguan;
    Toggle toggle11;
    Toggle toggle22;
    Toggle toggle33;
    public Sprite  sprite1;
    public Sprite sprite2;
    // public static GameObject graph2;
    // public static GameObject graph4;
    // Use this for initialization
    void Start () {
        //LineCH3COOH.SetActive(false);
       //LineBaOH2.SetActive(false);
       // LineNH4Cl.SetActive(false);
        chendian.SetActive(false);
       // Parch3 = GameObject.Find("particularCH3");
       // ParBa = GameObject.Find("particularBa");
        //ParNH = GameObject.Find("particularNH");
        // this.GetComponent<Button>().onClick.AddListener(Loaddianjiezhi);
        toggle = this.GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(Changeslidervalue);
       // toggleweiguan.onValueChanged.AddListener(Weiguanchange);
        // GameObject LineCH3COOH = GameObject.Find("LineCH3COOH");
        toggleweiguan = GameObject.Find("Toggleweiguan").GetComponent<Toggle>();
        toggle11= GameObject.FindWithTag("11").GetComponent<Toggle>();
        toggle22= GameObject.FindWithTag("22").GetComponent<Toggle>();
        toggle33 = GameObject.FindWithTag("33").GetComponent<Toggle>();

    }
	
	// Update is called once per frame
	void Update () {
        if (toggle22.isOn == true && toggleweiguan.isOn == false)
        {
            ParBa.SetActive(false );
            Parch3.SetActive(false);
            ParNH.SetActive(false);
            chendian.SetActive(true);
            qipao.SetActive(false);
        }
        else if(toggle33.isOn == true && toggleweiguan.isOn == false)
        {
            ParNH.SetActive(false);
            Parch3.SetActive(false);
            ParBa.SetActive(false);
            qipao.SetActive(true);
            chendian.SetActive(false);
            
        }
        else   if (toggle11.isOn == true && toggleweiguan.isOn == true)
        {
            
            Parch3.SetActive(true);
            ParBa.SetActive(false);
            ParNH.SetActive(false);
            chendian.SetActive(false);
            qipao.SetActive(false);

        }
        else if (toggle22.isOn == true && toggleweiguan.isOn == true)
        {
            ParBa.SetActive(true);
            Parch3.SetActive(false);
            ParNH.SetActive(false);
            chendian.SetActive(false);
            
            qipao.SetActive(false);
        }
        else if (toggle33.isOn == true && toggleweiguan.isOn == true)
        {
            ParNH.SetActive(true);
            Parch3.SetActive(false);
            ParBa.SetActive(false);
            qipao.SetActive(false);
            chendian.SetActive(false);
            
        }
        else
        {
            Parch3.SetActive(false);
            ParBa.SetActive(false);
            ParNH.SetActive(false);
            chendian.SetActive(false);
            qipao.SetActive(false);
        }
    }
   /* public  void  Loaddianjiezhi()
    {
        slider1.value = 0;
        Sliderchange.curvalue = 0;
        FunctionSetX2.x2 = 0;
       FunctionSetX4.x4 = 0;
            
        //Destroy(graph4.GetComponent<Line4>());
        if (this.name == "CH3COOH+NH3")
        {
           
            LineCH3COOH.SetActive(true);
            LineBaOH2.SetActive(false);
            LineNH4Cl.SetActive(false);
        }
        else if(this.name== "Ba(OH)2+H2SO4")
        {
            LineCH3COOH.SetActive(false);
            LineBaOH2.SetActive(true);
            LineNH4Cl.SetActive(false);
            chendian.SetActive(true);
        }
        else if(this.name== "NH4Cl+NaOH")
        {
            LineCH3COOH.SetActive(false);
            LineBaOH2.SetActive(false);
            LineNH4Cl.SetActive(true);
        }
    }*/
   void Changeslidervalue(bool isOn)
    {
        if (isOn  == true)
        {
            this.GetComponentInChildren<Image>().sprite = sprite2 ;
            slider1.value = 0;
            Sliderchange.curvalue = 0;
            FunctionSetX2.x2 = 0;
            FunctionSetX4.x4 = 0;
        }
        else
        {
            this.GetComponentInChildren<Image>().sprite = sprite1;
        }
        
    }
   
}
