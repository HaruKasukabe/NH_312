using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubecollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ink"))
        {
            GetComponent<Collider2D>().isTrigger = false;
            GetComponent<Renderer>().material.color = collision.GetComponent<Renderer>().material.color;
            collision.gameObject.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Material[] mats = GetComponent<Renderer>().materials;
        mats[1].color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
