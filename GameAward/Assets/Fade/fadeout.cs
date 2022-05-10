//==========================
//
//Sprincler.cs[キーボードのXを押して再生する]
//Author:Yoshimi Yamauchi
//
// 更新履歴
// 2022/4/29 フェードアウト基本部分の作製
// 2022/5/10 バグ取り終了(トランジションフェードアウト)
//
//==========================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fadeout : MonoBehaviour
{
    [SerializeField]
    private Fade fade;        //FadeCanvas取得
    [SerializeField]
    private float fadeTime;   //フェード時間

    // Start is called before the first frame update
    void Start()
    {
        fade.FadeOut(fadeTime); //フェードアウト開始
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
