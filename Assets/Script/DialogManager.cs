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
        
       
        Debug.Log(diallogbox.activeInHierarchy);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && diallogbox.activeInHierarchy)
        {
            

            if (dialogs.Length > dnumber)
            {
                dialog.text = dialogs[dnumber];
                dnumber++;

                Debug.Log(dnumber);

            }
            else
            {
                diallogbox.SetActive(false);
                resetdialog();
                Player.instance.setcanwalk(5f);
            }
            
           
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
    public void SetDialog(string[] dilogsArr)
    {
        dialogs = dilogsArr;
        dialog.text = dialogs[dnumber];
        dnumber = 1;
    }
   
}
