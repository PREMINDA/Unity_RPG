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
    private DialogBoxActivator NPC;
    
    public string[] dialogs;
   
    
    void Start()
    { 
        Debug.Log(diallogbox.activeInHierarchy);
        NPC = GameObject.Find("NPC").GetComponent<DialogBoxActivator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && diallogbox.activeInHierarchy)
        {
            dnumber++;
            CheckIfName();

            if (dialogs.Length > dnumber && dialogs[dnumber].StartsWith("n-") == false)
            {
                dialog.text = dialogs[dnumber];
                Debug.Log(dnumber);

            }
            else
            {
                diallogbox.SetActive(false);
                resetdialog();
                Player.instance.StopPlayer(true);
                NPC.ReReadDialog();
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
        CheckIfName();
        dialog.text = dialogs[dnumber];
        
        
    }
    
    public void CheckIfName()
    {
        if (dialogs.Length > dnumber && dialogs[dnumber].StartsWith("n-"))
        {
            name.text = dialogs[dnumber].Replace("n-","");
            dnumber++;
        }
    }
   
}
