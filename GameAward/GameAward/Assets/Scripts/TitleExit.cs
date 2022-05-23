//=================================
//タイトル画面からのゲーム終了処理
//Author:Ryo Tokuda
//更新履歴: 2022/04/01
//================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleExit : MonoBehaviour
{

    void Start()
    {

    }
    //マウス操作でゲーム終了処理↓
    public void ButtonExit()
    {
       
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }



    //コントローラーでゲーム終了処理↓
    void Update()
    {
        {
            if (Input.GetKeyDown("joystick button 1")) //XBOXコントローラーのBボタンでゲーム終了
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
