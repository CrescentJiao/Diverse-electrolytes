using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SpringFramework.UI;
using SpringFramework2.UI;
using SpringFramework3.UI;

public class Slidercontrol10 : MonoBehaviour
{
    public Slider slider;
    public GameObject graph1;
    public GameObject graph2;
    public GameObject graph3;
    
    float curvalue;
    // bool flag = false;
    // Use this for initialization
    void Start()
    {
        //InvokeRepeating("setX", 0.1f,0.001f);
        curvalue = slider.value;
       // graph1.AddComponent<FunctionalGraph>();
       // graph2.AddComponent<FunctionalGraph2>();
      //  graph3.AddComponent<FunctionalGraph3>();
    }
    public void setX()
    {
        //graph.SetActive(false);

        //slider = GameObject.Find("Slider").GetComponent<Slider>();

        //Debug.Log(FunctionSetX.x);
        //UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(GameObject.Find("Capsule"), "添加力", "Force");

        //Destroy(GetComponent<Force>());


        //FunctionalGraph.drawline();
        //graph.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        if (curvalue != slider.value)
        {
            //也许可以判断一下有拖拽我再destroy 和 add
            Destroy(graph1.GetComponent<FunctionalGraph>());
            Destroy(graph2.GetComponent<FunctionalGraph2>());
            Destroy(graph3.GetComponent<FunctionalGraph3>());
           
            FunctionSetX.x = slider.value;
            FunctionSetX2.x2 = slider.value;
            FunctionSetX3.x3 = slider.value;
            if (graph1.GetComponent<FunctionalGraph>() == null) { graph1.AddComponent<FunctionalGraph>(); }
            if (graph2.GetComponent<FunctionalGraph2>() == null) { graph2.AddComponent<FunctionalGraph2>(); }
            if (graph3.GetComponent<FunctionalGraph3>() == null) { graph3.AddComponent<FunctionalGraph3>(); }
            curvalue = slider.value;
        }
        else
        {
           // graph1.AddComponent<FunctionalGraph>();
           // graph2.AddComponent<FunctionalGraph2>();
           //graph3.AddComponent<FunctionalGraph3>();
            if (graph1.GetComponent<FunctionalGraph>() == null) { graph1.AddComponent<FunctionalGraph>(); }
            if (graph2.GetComponent<FunctionalGraph2>() == null) { graph2.AddComponent<FunctionalGraph2>(); }
            if (graph3.GetComponent<FunctionalGraph3>() == null) { graph3.AddComponent<FunctionalGraph3>(); }
        }

    }

}