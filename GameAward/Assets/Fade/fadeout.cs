using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fadeout : MonoBehaviour
{
    //[SerializeField]
    //private Fade fade;        //FadeCanvas�擾
    //[SerializeField]
    //private float fadeTime;   //�t�F�[�h����

    // Start is called before the first frame update
    void Start()
    {
        //�V�[���J�n�Ńg�����W�V����������ꍇ
        //fade.FadeOut(fadeTime);
        Debug.Log("FadeStart");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    //public void SceneTransition(int destination)
    //{
    //    //�g�����W�V�������|���ăV�[���J�ڂ���
    //    fade.FadeIn(fadeTime, () =>
    //    {
    //        SceneManager.LoadScene("Fade" + destination);
    //    });
    //}
}
