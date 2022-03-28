//=================================
//Author:Ryo Tokuda
//XV—š—ğ: 2022/03/28
//================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{
    public void SwitchScene()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
        void Start()
    {
        
    }

    void Update()
    {
        
    }
}
