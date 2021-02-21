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
    public static FadeUI instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        instance = this;
        img.color = new Color(img.color.r, img.color.g, img.color.b, 0f);
        DontDestroyOnLoad(gameObject);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldBlack)
        {
            img.color = new Color(img.color.r, img.color.g, img.color.b, Mathf.MoveTowards(img.color.a, 1f, fadeSpeed * Time.deltaTime));

            if(img.color.a == 1f)
            {
                shouldBlack = false;
            }
        }
        if (shouldFade)
        {
            img.color = new Color(img.color.r, img.color.g, img.color.b, Mathf.MoveTowards(img.color.a, 0f, fadeSpeed * Time.deltaTime));

            if (img.color.a == 0f)
            {
                shouldFade = false;
            }
        }
    }

    public IEnumerator FadeScreen()
    {
        img.color = new Color(img.color.r, img.color.g, img.color.b, 1f);
        yield return new WaitForSeconds(0.5f);

        
        shouldFade = true;
    }
    public void FadeScreenblack()
    {
        shouldBlack = true;
    }

}
