﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEnter : MonoBehaviour
{
    public string entrenceLocation;
    void Start()
    {
        if (entrenceLocation == Player.instance.areaTransestionName)
        {
            Player.instance.transform.position = transform.position;
        }
    }
    void Update()
    {

    }

}

    // Update is called once per frame
   

