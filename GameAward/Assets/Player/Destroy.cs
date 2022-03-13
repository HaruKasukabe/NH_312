using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject, 0.2f);
        }
    }

    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
