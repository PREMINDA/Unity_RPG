using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogBoxActivator : MonoBehaviour
{
    private DialogManager dm;
    private bool _isEnable = false;
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
            Player.instance.setcanwalk(0);
            _isEnable = false;
        }
        if (Input.GetKeyDown(KeyCode.Escape) && _isEnable ==false)
        {
            dm.DialogBoxActive(false);
            Player.instance.setcanwalk(5f);
            dm.resetdialog();
            _isEnable = true;
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
