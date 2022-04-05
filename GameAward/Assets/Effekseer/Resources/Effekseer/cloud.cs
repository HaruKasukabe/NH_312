//==========================
//
//Sprincler.cs[�_�G�t�F�N�g���Đ�����]
//Author:Yoshimi Yamauchi
//
// �X�V����
// 2022/4/1 ���b���o�߂���Ɖ_�G�t�F�N�g���Đ�����B
//
//==========================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Effekseer;

public class cloud : MonoBehaviour
{
    private EffekseerEmitter CloudEffect;
    public string objectName;

    float seconds;

    // Start is called before the first frame update
    void Start()
    {
        CloudEffect = GameObject.Find(objectName).GetComponent<EffekseerEmitter>();
    }

    // Update is called once per frame
    void Update()
    {
        // Do anything
        seconds += Time.deltaTime;  //���Ԃ̌v�Z�B
        
        if (seconds >= 100) //�ŏ��̍Đ�����100�b�o�߂���Ƃ�����x�G�t�F�N�g���Đ�����B(�G�t�F�N�g�̍Đ����Ԃƍ��킹�銴��)
        {
            CloudEffect.Play(); //�_�G�t�F�N�g���Đ�����B
            if (!CloudEffect.exists)    //�_�G�t�F�N�g�����݂�����
            {
                CloudEffect.StopRoot(); //�Đ����~����B
            }
            seconds = 0;    //seconds(�J�E���^)��0�ɂ���B
        }
    }
}
