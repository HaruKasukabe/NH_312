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

    [SerializeField] private GameObject lazer;          //���[�U�[�v���n�u���i�[
    [SerializeField] private Transform attackPoint;    //�A�^�b�N�|�C���g���i�[

    [SerializeField] private float attackTime = 0.2f;  //�U���̊Ԋu
    private float currentAttackTime;                  //�U���̊Ԋu���Ǘ�
    private bool canAttack;                           //�U���\��Ԃ����w�肷��t���O

    public float m_shotAngleRange;    //�e�𔭎˂���p�x

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
   
            currentAttackTime = attackTime; //currentAttackTime��attackTime���Z�b�g�B
    }

    void Update()
    {
        //=======�v���C���[����=============
        float x = Input.GetAxis("Horizontal");
        if (x == 0)
        {
            //�~�܂�
            moveDirection = MOVE_DIRECTION.STOP;
        }
        else if (x > 0)
        {
            //�E�Ɉړ�
            moveDirection = MOVE_DIRECTION.RIGHT;
        }
        else if (x<0)
        {
            //���Ɉړ�
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
        attackTime += Time.deltaTime; //attackTime�ɖ��t���[���̎��Ԃ����Z���Ă���

        if (attackTime > currentAttackTime)
        {
            canAttack = true; //�w�莞�Ԃ𒴂�����U���\�ɂ���
        }

        if (Input.GetKeyDown("joystick button 5") || Input.GetKeyDown(KeyCode.Z)) //R�X�e�B�b�N�܂���Z����������
        {
            if (canAttack)
            {
                //�������ɐ�������I�u�W�F�N�g�A��������Vector3�^�̍��W�A��O�����ɉ�]�̏��
                Instantiate(lazer, attackPoint.position, Quaternion.identity);
                canAttack = false;�@//�U���t���O��false�ɂ���
                attackTime = 0f;�@ //attackTime��0�ɖ߂�
            }
        }
    }
}
