using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogBoxActivator : MonoBehaviour
{
    private DialogManager dm;
    void Start()
    {
        dm = gameObject.GetComponent<DialogManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            
                dm.DialogBoxActive(true);
                //dm.DialogBoxActive(false);
        }
    }
}
