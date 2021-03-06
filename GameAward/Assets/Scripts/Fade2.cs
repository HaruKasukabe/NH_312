using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade2 : MonoBehaviour
{
    public bool isFadeout = false;
    float speed = 0.02f;
    Image fadepanel;
    float red, green, blue, alpha;
   

    void Start()
    {
        fadepanel = GetComponent<Image>();
        red = fadepanel.color.r;
        green = fadepanel.color.g;
        blue = fadepanel.color.b;
        alpha = fadepanel.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFadeout)
        {
            Fadeout();
        }
    }

void Fadeout()
    {
        alpha += speed;
        fadepanel.color = new Color(red, green, blue, alpha);
        if(alpha >=1)
        {
            isFadeout = false;
        }
    }
}
