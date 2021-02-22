﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogBoxActivator : MonoBehaviour
{
    private DialogManager dm;
    private bool _isEnable = false;
    void Start()
    {
        dm = GameObject.Find("Canvas").GetComponent<DialogManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _isEnable == true)
        {
            dm.DialogBoxActive(true);
            Player.instance.setcanwalk(0);
        }
        if (Input.GetKeyDown(KeyCode.Escape) && _isEnable == true)
        {
            dm.DialogBoxActive(false);
            Player.instance.setcanwalk(5f);
            dm.resetdialog();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {

            _isEnable = true;
                //dm.DialogBoxActive(false);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            _isEnable = false;
            dm.resetdialog();

        }
    }
}
