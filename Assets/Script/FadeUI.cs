using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeUI : MonoBehaviour
{
    public Image img;
    public bool shouldBlack;
    public bool shouldFade;
    private float fadeSpeed = 1;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldBlack)
        {
            img.color = new Color(img.color.r, img.color.g, img.color.b, Mathf.MoveTowards(img.color.a, 1f, fadeSpeed * Time.deltaTime));
        }
    }
}
