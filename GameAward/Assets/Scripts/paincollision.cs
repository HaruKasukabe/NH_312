//==============================
//�X�V��: Ryo Tokuda
//�X�V����:2022/04/03 �X�R�A�ϐ�������đS���W�߂���N���A�V�[���Ɉڂ�悤�ɂ��܂���
//===================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class paincollision : MonoBehaviour
{
    public Text Scoretext;
    private int score = 0;

    void OnTriggerEnter2D(Collider2D collision)
    {
        score += 10;

      

        if (collision.gameObject.CompareTag("ink"))
        {
            GetComponent<Collider2D>().isTrigger = false;
            collision.gameObject.SetActive(false);
            Destroy(this.gameObject);

            Scoretext.text = string.Format("Score:{0}", score);
        }
        if (score == 40)   //4�ʂ��������X�e�[�W�I���ɍs��
        {
            SceneManager.LoadScene("SelectScene");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
      
    }
}
