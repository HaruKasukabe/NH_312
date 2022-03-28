using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.material.color = sr.material.color - new Color32(0, 0, 0, 255);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
