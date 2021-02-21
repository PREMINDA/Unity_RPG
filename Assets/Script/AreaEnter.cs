using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AreaEnter : MonoBehaviour
{
    public string entrenceLocation;
    void Start()
    {
        if (entrenceLocation == Player.instance.areaTransestionName)
        {
            Player.instance.transform.position = transform.position;
            StartCoroutine(FadeUI.instance.FadeScreen());
            
        }
    }
    void Update()
    {

    }

}

    // Update is called once per frame
   

