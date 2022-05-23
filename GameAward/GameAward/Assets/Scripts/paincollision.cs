using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paincollision : MonoBehaviour
{
    public bool painted;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ink") && !(painted))
        {
            collision.gameObject.SetActive(false);
            this.GetComponent<SpriteRenderer>().color += new Color(0, 0, 0, 100);
            painted = true;
            Clear.GoalNum += 1;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        painted = false;
        this.GetComponent<SpriteRenderer>().color += new Color(0, 0, 0, -100);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
