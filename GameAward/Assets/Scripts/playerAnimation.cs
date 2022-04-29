using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimation : MonoBehaviour
{
    public static Animator playerAnim = null;
    private int jumpCount = 0;
    bool lastKeyRight;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalKey = Input.GetAxis("Horizontal");

        if (horizontalKey > 0)
        {
            playerAnim.SetBool("walkRight", true);
            lastKeyRight = true;
        }
        else if (horizontalKey < 0)
        {
            playerAnim.SetBool("walkLeft", true);
            lastKeyRight = false;
        }
        else
        {
            playerAnim.SetBool("walkRight", false);
            playerAnim.SetBool("walkLeft", false);
        }

        if((Input.GetKeyDown("joystick button 1") && this.jumpCount < 0) || (Input.GetKeyDown(KeyCode.Space) && this.jumpCount < 0))
        {
            playerAnim.SetTrigger("jump");
            jumpCount++;
        }

        if (Input.GetMouseButtonUp(0))
        {
            playerAnim.SetTrigger("shot");
        }
        if (Input.GetKeyUp("joystick button 7"))
        {
            playerAnim.SetTrigger("shot");
        }

        if (lastKeyRight)
            playerAnim.SetBool("lastKeyRight", true);
        else
            playerAnim.SetBool("lastKeyRight", false);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            jumpCount = -1;
        }
    }
}
