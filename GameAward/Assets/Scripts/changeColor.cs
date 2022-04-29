using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    public Material material;
    GameObject ink;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (material.name == "WhiteSpot")
            {
                SetColor("white");
            }
            if (material.name == "RedSpot")
            {
                switch (ink.GetComponent<Renderer>().material.name)
                {
                    case "blue":
                        SetColor("magenta");
                        break;
                    default:
                        SetColor("red");
                        break;
                }
            }
            if (material.name == "BlueSpot")
            {
                switch (ink.GetComponent<Renderer>().material.name)
                {
                    case "red":
                        SetColor("magenta");
                        break;
                    default:
                        SetColor("blue");
                        break;
                }
            }
        }
    }

    void SetColor(string color)
    {
        switch (color)
        {
            case "white":
                ink.GetComponent<Renderer>().material.color = Color.white;
                ink.GetComponent<LineRenderer>().material.color = Color.white;
                ink.GetComponent<Renderer>().material.name = color;
                ink.GetComponent<LineRenderer>().material.name = color;
                break;
            case "red":
                ink.GetComponent<Renderer>().material.color = Color.red;
                ink.GetComponent<LineRenderer>().material.color = Color.red;
                ink.GetComponent<Renderer>().material.name = color;
                ink.GetComponent<LineRenderer>().material.name = color;
                break;
            case "blue":
                ink.GetComponent<Renderer>().material.color = Color.blue;
                ink.GetComponent<LineRenderer>().material.color = Color.blue;
                ink.GetComponent<Renderer>().material.name = color;
                ink.GetComponent<LineRenderer>().material.name = color;
                break;
            case "magenta":
                ink.GetComponent<Renderer>().material.color = Color.magenta;
                ink.GetComponent<LineRenderer>().material.color = Color.magenta;
                ink.GetComponent<Renderer>().material.name = color;
                ink.GetComponent<LineRenderer>().material.name = color;
                break;
        }   
    }

    // Start is called before the first frame update
    void Start()
    {
        ink = GameObject.FindWithTag("ink");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
