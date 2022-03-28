//==========================
//
//Sprincler.cs[�L�[�{�[�h��X�������čĐ�����]
//Author:Yoshimi Yamauchi
//
// �X�V����
// 2022/3/28 �L�[�{�[�h��X�������ƃX�v�����N���[�̃G�t�F�N�g���Đ�����B
//
//==========================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprincler : MonoBehaviour
{
    GameObject pObject;
    ParticleSystem particle;

    void Start()
    {
        particle = GetComponent<ParticleSystem>();  //ParticleSystem�R���|�[�l���g��particle�ϐ��Ɋi�[�B
        particle.Stop();                            //�p�[�e�B�N���V�X�e����~
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            particle.time = 0;  //���Z�b�g����Ȃ��B
            particle.Play();    //�p�[�e�B�N���V�X�e���Đ�
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            particle.time = 3;  //�r������Đ�����Ȃ��B
            particle.Play();    //�p�[�e�B�N���V�X�e���Đ�
        }
    }
}
