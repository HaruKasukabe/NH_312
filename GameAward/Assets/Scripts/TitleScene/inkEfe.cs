using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inkEfe : MonoBehaviour
{
    private int nInkTime;

    // Start is called before the first frame update
    void Start()
    {
        nInkTime = 100;   
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Material>().color += new Color(0, 0, 0, -1);
        nInkTime--;
        if (nInkTime < 0)
        {
            //Random random;
            GetComponent<Transform>().position = new Vector3(0, 9, 0);
        }
    }
}
