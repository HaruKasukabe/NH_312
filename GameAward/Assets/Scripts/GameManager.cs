//=================================
//�X�^�[�g�{�^��
//Author:Ryo Tokuda
//�X�V����: 2022/04/01
//================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void StartButton()
    {
        FadeManager.Instance.LoadScene("SelectScene", 0.5f);
        SceneManager.LoadScene("SelectScene");
      
    }

}
