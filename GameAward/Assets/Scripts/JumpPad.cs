using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    private Animator anim = null;
    public bool painted;
    public Sprite sprite;
    int animTime;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ink") && !(painted))
        {
            collision.gameObject.SetActive(false);
            this.GetComponent<SpriteRenderer>().sprite = sprite;
            this.GetComponent<BoxCollider2D>().isTrigger = false;
            anim.SetBool("painted", true);
            painted = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 1500.0f);
            anim.SetBool("OnPlayer", true);
            animTime = 10;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        animTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        animTime--;
        if (animTime < 0)
            anim.SetBool("OnPlayer", false);
    }
}
