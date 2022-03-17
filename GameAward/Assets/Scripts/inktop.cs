using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inktop : MonoBehaviour
{
    bool mouseButton = false;
    Transform firstPos;

    // Start is called before the first frame update
    void Start()
    {
        firstPos = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Transform inkTop = this.transform;
        Vector3 pos = inkTop.position;

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

            pos.y -= Time.deltaTime * 3;

        }
        else
        {
            if (-3 >= pos.y)
                pos.y += Time.deltaTime * 3;

        }

        inkTop.position = pos;
    }
}
