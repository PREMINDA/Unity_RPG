﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{
    [SerializeField]
    private string _areaToLoad;
    public string areaTransestionName;

    


    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            StartCoroutine(wait());
            Player.instance.setcanwalk(0f);
            FadeUI.instance.FadeScreenblack();
           
        }
    }
    private IEnumerator wait()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(_areaToLoad);
        Player.instance.areaTransestionName = areaTransestionName;
        Player.instance.setcanwalk(5f);
    }
}
