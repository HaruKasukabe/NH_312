using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{

    [SerializeField]

    public Image image;

    bool mouseButton = false;

    void Start()
    {
        image = GetComponent<Image>();
    }


    void Update()
    {
        /* if (Input.GetKeyDown("joystick button 5" )|| Input.GetMouseButton(0))
         {
             image.fillAmount -= Time.deltaTime;
         }
         else
         {

             image.fillAmount += Time.deltaTime;
         }
     }
     */

        // マウスを使ってゲージを増減させる
        if (Input.GetKeyDown("joystick button 5") || Input.GetMouseButtonDown(0))
        {
            mouseButton = true;
            
        }
        else if (Input.GetKeyDown("joystick button 5") || Input.GetMouseButtonUp(0))
        {
            mouseButton = false;
        }


        if (mouseButton)
        {

            image.fillAmount -= Time.deltaTime;

        }
        else if (image.fillAmount > 0f)
        {

            image.fillAmount += Time.deltaTime;

        }

    }
}