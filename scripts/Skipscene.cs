using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Skipscene : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(change);
    }
    public void change()
    {
        if (this.name == "1to2")
        {
            SceneManager.LoadScene("dianjiezhi2");
        }
        else if (this.name == "2to1")
        {
            SceneManager.LoadScene("dianjiezhi1");
        }
       
    }
    // Update is called once per frame
    void Update()
    {

    }
}
