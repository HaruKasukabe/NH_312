//======================================================================================================================================================
// SelectStage.cs[ステージ選択画面のプレイヤーの移動]
//Author: RYO TOKUDA & Yoshimi Ymauchi
//更新履歴: 2022/03/28
//          2022/05/12 山内ヨシミ ボタンをふわふわさせる設定(SetTrigerの()部分をHighlight → Noneに変更) 主に間違っていたのはUnityのAnimatorの設定。
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
        Button MenuButton = GetComponent<Button>();    // 対象のボタン
        MenuButton.animator.SetTrigger("None");
    }
}
