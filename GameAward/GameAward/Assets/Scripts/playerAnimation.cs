using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimation : MonoBehaviour
{
    private Animator anim = null;
    private int jumpCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalKey = Input.GetAxis("Horizontal");

        if (horizontalKey > 0)
        {
            anim.SetBool("walkRight", true);
        }
        else if (horizontalKey < 0)
        {
            anim.SetBool("walkLeft", true);
        }
        else
        {
            anim.SetBool("walkRight", false);
            anim.SetBool("walkLeft", false);
        }

        if((Input.GetKeyDown("joystick button 1") && this.jumpCount < 0) || (Input.GetKeyDown(KeyCode.Space) && this.jumpCount < 0))
        {
            anim.SetTrigger("jump");
            jumpCount++;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            jumpCount = -1;
        }
    }
}
