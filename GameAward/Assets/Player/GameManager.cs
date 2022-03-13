using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject ball;
   
    void Update()
    {
        if(Input.GetKey("right"))
        {
            transform.Rotate(0, 2, 0);
        }

        if(Input.GetKey("left"))
        {
            transform.Rotate(0, -2, 0);
        }
        if(Input.GetKey("space"))
        {
            Instantiate(ball, transform.position, transform.rotation);
        }
    }
}
