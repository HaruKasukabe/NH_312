using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fadeout : MonoBehaviour
{
    //[SerializeField]
    //private Fade fade;        //FadeCanvas取得
    //[SerializeField]
    //private float fadeTime;   //フェード時間

    // Start is called before the first frame update
    void Start()
    {
        //シーン開始でトランジションを入れる場合
        //fade.FadeOut(fadeTime);
        Debug.Log("FadeStart");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    //public void SceneTransition(int destination)
    //{
    //    //トランジションを掛けてシーン遷移する
    //    fade.FadeIn(fadeTime, () =>
    //    {
    //        SceneManager.LoadScene("Fade" + destination);
    //    });
    //}
}
