using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogBoxActivator : MonoBehaviour
{
    private DialogManager dm;
    private bool _isEnable = false;
    private bool _isEscapeEnable = false;
    public string[] dialogs;
    void Start()
    {
        dm = GameObject.Find("Canvas").GetComponent<DialogManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _isEnable == true)
        {
            dm.SetDialog(dialogs);
            dm.DialogBoxActive(true);
            //Player.instance.setcanwalk(0);
            Player.instance.StopPlayer(false);
            _isEnable = false;
            _isEscapeEnable = true;
        }
        if (Input.GetKeyDown(KeyCode.Escape) && _isEscapeEnable == true)
        {
            dm.DialogBoxActive(false);
            //Player.instance.setcanwalk(5f);
            Player.instance.StopPlayer(true);
            dm.resetdialog();
            _isEnable = true;
            _isEscapeEnable = false;
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
            _isEscapeEnable = false;
            dm.resetdialog();


        }
    }
    public void ReReadDialog()
    {
        _isEnable = true;
    }
}
