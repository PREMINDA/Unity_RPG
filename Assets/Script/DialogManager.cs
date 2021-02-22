using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public new Text name;
    [SerializeField]
    private Text dialog;
    [SerializeField]
    private GameObject diallogbox;
    [SerializeField]
    private GameObject namebox;
    [SerializeField]
    private int dnumber = 0;
   

    public string[] dialogs;
   
    
    void Start()
    {
        
        dialogs = new string[] {"shdialog","asd","qwe","asd","dfg","ert","345","fgh","vbn","jgh","fgh","rrte","wer" };
        Debug.Log(diallogbox.activeInHierarchy);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && diallogbox.activeInHierarchy)
        {

            if (dialogs.Length - 1 > dnumber)
            {
                dnumber++;

                Debug.Log(dnumber);

            }
            else
            {
                diallogbox.SetActive(false);
                resetdialog();
                Player.instance.setcanwalk(5f);
            }
            
            dialog.text = dialogs[dnumber];
        }
       
      
    }
    public void DialogBoxActive(bool set)
    {
        diallogbox.SetActive(set);
    }
    public void resetdialog()
    {
        dnumber = 0;
        Debug.Log("ResetDialog");
        Debug.Log(dnumber);
    }
   
}
