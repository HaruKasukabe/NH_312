//=================================
//スタートボタン
//Author:Ryo Tokuda
//更新履歴: 2022/04/01
//================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void StartButton()
    {
        SceneManager.LoadScene("SelectScene");
    }

}
