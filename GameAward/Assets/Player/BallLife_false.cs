using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLife_false : MonoBehaviour
{
    Renderer Line_Renderer; // ���肵�����I�u�W�F�N�g�̃����_���[�ւ̎Q��
    bool flg = false;

    // Start is called before the first frame update
    void Start()
    {
        Line_Renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Line_Renderer.isVisible)
            flg = true;
        if(!Line_Renderer.isVisible&&flg)
        {
            // �I�u�W�F�N�g����ʂ����������
            gameObject.SetActive(false);
        }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            gameObject.SetActive(false);
        }
    }
}
