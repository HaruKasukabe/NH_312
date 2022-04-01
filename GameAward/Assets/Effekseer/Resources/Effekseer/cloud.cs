//==========================
//
//Sprincler.cs[雲エフェクトを再生する]
//Author:Yoshimi Yamauchi
//
// 更新履歴
// 2022/4/1 一定秒数経過すると雲エフェクトを再生する。
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
        seconds += Time.deltaTime;  //時間の計算。
        
        if (seconds >= 100) //最初の再生から100秒経過するともう一度エフェクトを再生する。(エフェクトの再生時間と合わせる感じ)
        {
            CloudEffect.Play(); //雲エフェクトを再生する。
            if (!CloudEffect.exists)    //雲エフェクトが存在したら
            {
                CloudEffect.StopRoot(); //再生を停止する。
            }
            seconds = 0;    //seconds(カウンタ)を0にする。
        }
    }
}
