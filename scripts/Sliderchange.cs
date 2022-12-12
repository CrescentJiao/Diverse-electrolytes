using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SpringFramework11.UI;
using SpringFramework22.UI;
using SpringFramework33.UI;
using SpringFramework44.UI;
using SpringFramework55.UI;


public class Sliderchange : MonoBehaviour
{
    public Slider slider1;
    public GameObject graph1;
    public GameObject graph2;
    public GameObject graph3;
    public GameObject graph4;
    public GameObject graph5;
   public static float  curvalue;
    // bool flag = false;
    // Use this for initialization
    void Start()
    {
        //InvokeRepeating("setX", 0.1f,0.001f);
        curvalue = slider1.value;
        // graph1.AddComponent<FunctionalGraph>();
        // graph2.AddComponent<FunctionalGraph2>();
        //  graph3.AddComponent<FunctionalGraph3>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if(slider1.value == 0)
            {
            Destroy(graph1.GetComponent<Line1>());
            Destroy(graph3.GetComponent<Line3>());
            Destroy(graph5.GetComponent<Line5>());
            Destroy(graph2.GetComponent<Line2>());
            Destroy(graph4.GetComponent<Line4>());
        }else  if (curvalue != slider1.value)
        {
            
            if(slider1.value <= 50)
            {
                Destroy(graph1.GetComponent<Line1>());
                Destroy(graph3.GetComponent<Line3>());
                Destroy(graph5.GetComponent<Line5>());
               
               /// graph2.SetActive(false);
                //graph4.SetActive(false);
                FunctionSetX.x = slider1.value;
                FunctionSetX3.x3 = slider1.value;
                FunctionSetX5.x5 = slider1.value;
                if (graph1.GetComponent<Line1>() == null) { graph1.AddComponent<Line1>(); }
                if (graph3.GetComponent<Line3>() == null) { graph3.AddComponent<Line3>(); }
                if (graph5.GetComponent<Line5>() == null) { graph5.AddComponent<Line5>(); }
                //graph1.AddComponent<Line1>();
                curvalue = slider1.value;
            }else if(slider1.value > 50)
            {
                //graph2.SetActive(true);
               // graph4.SetActive(true);
                Destroy(graph2.GetComponent<Line2>());
                Destroy(graph4.GetComponent<Line4>());
                Destroy(graph5.GetComponent<Line5>());
                FunctionSetX2.x2 = slider1.value;
                FunctionSetX4.x4 = slider1.value;
                FunctionSetX5.x5 = slider1.value;
                if (graph2.GetComponent<Line2>() == null) { graph2.AddComponent<Line2>(); }
                if (graph4.GetComponent<Line4>() == null) { graph4.AddComponent<Line4>(); }
                if (graph5.GetComponent<Line5>() == null) { graph5.AddComponent<Line5>(); }
                //  graph2.AddComponent<Line2>();
                curvalue = slider1.value;
            }
            

        }
        else 
        {
            if(graph1.GetComponent<Line1>() == null) {graph1.AddComponent<Line1>(); }
            if (graph2.GetComponent<Line2>() == null) { graph2.AddComponent<Line2>(); }
            if (graph3.GetComponent<Line3>() == null) { graph3.AddComponent<Line3>(); }
           if(graph4.GetComponent<Line4>() == null) { graph4.AddComponent<Line4>(); }
            if (graph5.GetComponent<Line5>() == null) { graph5.AddComponent<Line5>(); }
        }

    }

}