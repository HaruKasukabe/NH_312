//==================================================
// PlayerMovement.cs[vC[ÌìÖW]
//Author: RYO TOKUDA

//=================================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] LayerMask blockLayer;
    Rigidbody2D rigidbody2D;
    float speed = 0;
    private float jumpForce = 700f;

    public static int jumpCount;

    [SerializeField]
    private GameObject bullet;

    [SerializeField] private GameObject lazer;          //[U[vnuði[
    [SerializeField] private Transform attackPoint;    //A^bN|Cgði[

    [SerializeField] private float attackTime = 0.2f;  //UÌÔu
    private float currentAttackTime;                  //UÌÔuðÇ
    private bool canAttack;                           //UÂ\óÔ©ðwè·étO

    public float m_shotAngleRange;    //eð­Ë·épx

    public AudioClip jump;
    public AudioClip walk;
    AudioSource audioSource;
    bool bWalkSound;

    public enum MOVE_DIRECTION
    {
        STOP,
        LEFT,
        RIGHT,
    }
    MOVE_DIRECTION moveDirection = MOVE_DIRECTION.STOP;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
   
            currentAttackTime = attackTime; //currentAttackTimeÉattackTimeðZbgB

        audioSource = GetComponent<AudioSource>();
        bWalkSound = false;
        jumpCount = 0;
    }

    void Update()
    {
        //=======vC[ì=============
        float x = Input.GetAxis("Horizontal");
        if (x == 0)
        {
            //~Üé
            moveDirection = MOVE_DIRECTION.STOP;

            bWalkSound = false;
        }
        else if (x > 0)
        {
            //EÉÚ®
            moveDirection = MOVE_DIRECTION.RIGHT;

            if (!bWalkSound)
            {
                audioSource.PlayOneShot(walk);
                bWalkSound = true;
            }
        }
        else if (x<0)
        {
            //¶ÉÚ®
            moveDirection = MOVE_DIRECTION.LEFT;

            if (!bWalkSound)
            {
                audioSource.PlayOneShot(walk);
                bWalkSound = true;
            }
        }
        if((Input.GetKeyDown("joystick button 1") && jumpCount < 0) || (Input.GetKeyDown(KeyCode.Space) && jumpCount < 0))
        {
            this.rigidbody2D.AddForce(transform.up * jumpForce);
            jumpCount++;

            audioSource.PlayOneShot(jump);
        }

        //if (Input.GetMouseButtonDown(0))
        //{
        //    Instantiate(bullet, transform.position, Quaternion.identity);

        //    GameObject g = Instantiate(bullet, transform.position, Quaternion.identity);
        //    g.GetComponent<Bullet>().getVector(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition));
        //}
        //Attack();
        //=========================================
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            jumpCount = -1;
        }
    }

    private void FixedUpdate()
    {
        switch (moveDirection)
        {
            case MOVE_DIRECTION.STOP:
                speed = 0;
                break;
            case MOVE_DIRECTION.LEFT:
                speed = -10;
                break;
            case MOVE_DIRECTION.RIGHT:
                speed = 10;
                break;
        }
        rigidbody2D.velocity = new Vector2(speed,rigidbody2D.velocity.y);

    }

    void Attack()
    {
        attackTime += Time.deltaTime; //attackTimeÉt[ÌÔðÁZµÄ¢­

        if (attackTime > currentAttackTime)
        {
            canAttack = true; //wèÔð´¦½çUÂ\É·é
        }

        if (Input.GetKeyDown("joystick button 5") || Input.GetKeyDown(KeyCode.Z)) //RXeBbNÜ½ÍZðµ½ç
        {
            if (canAttack)
            {
                //æêøÉ¶¬·éIuWFNgAæñøÉVector3^ÌÀWAæOøÉñ]Ìîñ
                Instantiate(lazer, attackPoint.position, Quaternion.identity);
                canAttack = false;@//UtOðfalseÉ·é
                attackTime = 0f;@ //attackTimeð0Éß·
            }
        }
    }
}
