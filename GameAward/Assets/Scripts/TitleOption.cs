//=================================
//�I�v�V�����{�^��
//Author:Ryo Tokuda
//�X�V����: 2022/04/01
//================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleOption : MonoBehaviour
{
    
    void Start()
    {
        
    }
 
    void Update()
    {
        
    }
    public void StartButton()
    {
        FadeManager.Instance.LoadScene("OptionScene", 0.5f);
        SceneManager.LoadScene("OptionScene");
    }
}
