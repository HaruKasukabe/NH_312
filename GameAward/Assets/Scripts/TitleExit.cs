//=================================
//�^�C�g����ʂ���̃Q�[���I������
//Author:Ryo Tokuda
//�X�V����: 2022/04/01
//================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleExit : MonoBehaviour
{

    void Start()
    {

    }
    //�}�E�X����ŃQ�[���I��������
    public void ButtonExit()
    {
       
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }



    //�R���g���[���[�ŃQ�[���I��������
    void Update()
    {
        {
            if (Input.GetKeyDown("joystick button 1")) //XBOX�R���g���[���[��B�{�^���ŃQ�[���I��
            {
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
            }
        }
    }
}
