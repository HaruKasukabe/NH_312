using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLine : MonoBehaviour
{
    public GameObject ball_line;
    float speed;

    public AudioClip sound1;

    void Start()
    {
        speed = 30.0f;  // �e�̑��x

    }

    // Update is called once per frame
    void Update()
    {
        // �E�N���b�N�ŃC���N�̋O�Ղ��o��
        if (Input.GetMouseButtonDown(1) || Input.GetKeyDown("joystickbutton4"))
        {
            // �e�i�Q�[���I�u�W�F�N�g�j�̐���
            GameObject clone = Instantiate(ball_line, transform.position, Quaternion.identity);

            // �N���b�N�������W�̎擾�i�X�N���[�����W���烏�[���h���W�ɕϊ��j
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // �����̐����iZ�����̏����Ɛ��K���j
            Vector3 shotForward = Vector3.Scale((mouseWorldPos - transform.position), new Vector3(1, 1, 0)).normalized;

            // �e�ɑ��x��^����
            clone.GetComponent<Rigidbody2D>().velocity = shotForward * speed;

        }
    }

}
