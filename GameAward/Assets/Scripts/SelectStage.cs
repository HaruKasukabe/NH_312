//==================================================
// SelectStage.cs[�X�e�[�W�I����ʂ̃v���C���[�̈ړ�]
//Author: RYO TOKUDA
//�X�V����: 2022/03/28
//=================================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //�V�[���J�ڂ����邽�߂ɕK�v

public class SelectStage : MonoBehaviour
{
    //�X�^�[�g�ƏI���̖ڈ�
    public Transform startMarker;
    public Transform endMarker;
    private float speed = 1.0f;       //�v���C���[�̃X�s�[�h

    //��_�Ԃ̋���������
    private float distance_two;

    private SpriteRenderer renderer;  //�v���C���[�𔽓]��������

    void Start()
    {
       
    }
    void Update()
    {
        // ���݂̈ʒu
        float present_Location = (Time.time * speed) / distance_two;

        // �I�u�W�F�N�g�̈ړ�
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, present_Location);
         
        Vector2 position = transform.position;
        float x = Input.GetAxis("Horizontal");

        if (Input.GetKey("left"))
        {
            position.x -= speed;
            renderer.flipX = true;
        }
        else if (Input.GetKey("right"))
        {
            position.x += speed;
            renderer.flipX = false;
        }
        else if (Input.GetKey("up"))
        {
            position.y += speed;
        }
        else if (Input.GetKey("down"))
        {
            position.y -= speed;
        }

        transform.position = position;
    }

     void OnTriggerEnter2D(Collider2D  collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}


  /* //--------�}�E�X����ړ���--------
   private Vector3 mouse;
    private Vector3 target;

    void Update()
    {
        mouse = Input.mousePosition;
        target = Camera.main.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, 10));
        //target.y = transform.position.y;
        this.transform.position = target;
    }
    
}
*/