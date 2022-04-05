using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inkUIAnimation : MonoBehaviour
{
    private Animator anim = null;
    int num;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        num = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            switch(num)
            {
                case 0:
                    anim.SetBool("ink1", true);
                    num++;
                    break;
                case 1:
                    anim.SetBool("ink2", true);
                    num++;
                    break;
                default:
                    break;
            }
        }

        if (Input.GetKeyUp("joystick button 7"))
        {
            switch (num)
            {
                case 0:
                    anim.SetBool("ink1", true);
                    num++;
                    break;
                case 1:
                    anim.SetBool("ink2", true);
                    num++;
                    break;
                default:
                    break;
            }
        }
    }
}
