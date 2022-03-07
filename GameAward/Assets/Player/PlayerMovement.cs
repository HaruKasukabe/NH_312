using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] LayerMask blockLayer;
    Rigidbody2D rigidbody2D;
    float speed = 0;
    private float jumpForce = 700f;

    private int jumpCount = 0;

    [SerializeField]
    private GameObject bullet;

    [SerializeField] private GameObject lazer;          //レーザープレハブを格納
    [SerializeField] private Transform attackPoint;    //アタックポイントを格納

    [SerializeField] private float attackTime = 0.2f;  //攻撃の間隔
    private float currentAttackTime;                  //攻撃の間隔を管理
    private bool canAttack;                           //攻撃可能状態かを指定するフラグ

    public float m_shotAngleRange;    //弾を発射する角度

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
   
            currentAttackTime = attackTime; //currentAttackTimeにattackTimeをセット。
    }

    void Update()
    {
        //=======プレイヤー操作=============
        float x = Input.GetAxis("Horizontal");
        if (x == 0)
        {
            //止まる
            moveDirection = MOVE_DIRECTION.STOP;
        }
        else if (x > 0)
        {
            //右に移動
            moveDirection = MOVE_DIRECTION.RIGHT;
        }
        else if (x<0)
        {
            //左に移動
            moveDirection = MOVE_DIRECTION.LEFT;
        }
        if(Input.GetKeyDown("joystick button 0")|| Input.GetKeyDown("space") && this.jumpCount < 0)
        {
            this.rigidbody2D.AddForce(transform.up * jumpForce);
            jumpCount++;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);

            GameObject g = Instantiate(bullet, transform.position, Quaternion.identity);
            g.GetComponent<Bullet>().getVector(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
        Attack();
        //=========================================
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            jumpCount = 0;
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
        attackTime += Time.deltaTime; //attackTimeに毎フレームの時間を加算していく

        if (attackTime > currentAttackTime)
        {
            canAttack = true; //指定時間を超えたら攻撃可能にする
        }

        if (Input.GetKeyDown("joystick button 5") || Input.GetKeyDown(KeyCode.Z)) //RスティックまたはZを押したら
        {
            if (canAttack)
            {
                //第一引数に生成するオブジェクト、第二引数にVector3型の座標、第三引数に回転の情報
                Instantiate(lazer, attackPoint.position, Quaternion.identity);
                canAttack = false;　//攻撃フラグをfalseにする
                attackTime = 0f;　 //attackTimeを0に戻す
            }
        }
    }
}
