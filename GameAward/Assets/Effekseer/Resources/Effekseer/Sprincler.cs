//==========================
//
//Sprincler.cs[キーボードのXを押して再生する]
//Author:Yoshimi Yamauchi
//
// 更新履歴
// 2022/3/28 キーボードのXを押すとスプリンクラーのエフェクトを再生する。
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
        particle = GetComponent<ParticleSystem>();  //ParticleSystemコンポーネントをparticle変数に格納。
        particle.Stop();                            //パーティクルシステム停止
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            particle.time = 0;  //リセットされない。
            particle.Play();    //パーティクルシステム再生
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            particle.time = 3;  //途中から再生されない。
            particle.Play();    //パーティクルシステム再生
        }
    }
}
