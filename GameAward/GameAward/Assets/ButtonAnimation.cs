//======================================================================================================================================================
// SelectStage.cs[�X�e�[�W�I����ʂ̃v���C���[�̈ړ�]
//Author: RYO TOKUDA & Yoshimi Ymauchi
//�X�V����: 2022/03/28
//          2022/05/12 �R�����V�~ �{�^�����ӂ�ӂ킳����ݒ�(SetTriger��()������Highlight �� None�ɕύX) ��ɊԈ���Ă����̂�Unity��Animator�̐ݒ�B
//=====================================================================================================================================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAnimation : MonoBehaviour
{
    void Start()
    {
       
    }

    void Update()
    {
        Button MenuButton = GetComponent<Button>();    // �Ώۂ̃{�^��
        MenuButton.animator.SetTrigger("None");
    }
}
