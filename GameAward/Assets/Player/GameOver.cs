using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    Renderer PlayerAlive;
    Vector2 OldPos;
    // Start is called before the first frame update
    void Start()
    {
        PlayerAlive = GetComponent<Renderer>();
        OldPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerAlive.isVisible)
        {
            Debug.Log("—Ž‚¿‚½");
            gameObject.transform.position = OldPos;
                  
        }
        else
        {
            Debug.Log("—Ž‚¿‚Ä‚¢‚È‚¢");
        }
    }
}
