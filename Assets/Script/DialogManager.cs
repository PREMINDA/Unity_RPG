using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public new Text name;
    public Text dialog;
    public GameObject diallogbox;
    public GameObject namebox;
    private int dnumber = 0;

    public string[] dialogs;
    void Start()
    {
        dialogs = new string[] {"shdialog","asd","qwe","asd","dfg","ert","345","fgh","vbn","jgh","fgh","rrte","wer" };
       
    }

    // Update is called once per frame
    void Update()
    {
        dialog.text = dialogs[dnumber];
        StartCoroutine(waitfordialog());
    }

    public IEnumerator waitfordialog()
    {
        yield return new WaitForSeconds(2f);
        if (dnumber <= dialogs.Length)
        {

        dnumber++;
        }

    }
}
