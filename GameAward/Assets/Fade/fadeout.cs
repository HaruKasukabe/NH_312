//==========================
//
//Sprincler.cs[�L�[�{�[�h��X�������čĐ�����]
//Author:Yoshimi Yamauchi
//
// �X�V����
// 2022/4/29 �t�F�[�h�A�E�g��{�����̍쐻
// 2022/5/10 �o�O���I��(�g�����W�V�����t�F�[�h�A�E�g)
//
//==========================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fadeout : MonoBehaviour
{
    [SerializeField]
    private Fade fade;        //FadeCanvas�擾
    [SerializeField]
    private float fadeTime;   //�t�F�[�h����

    // Start is called before the first frame update
    void Start()
    {
        fade.FadeOut(fadeTime); //�t�F�[�h�A�E�g�J�n
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
