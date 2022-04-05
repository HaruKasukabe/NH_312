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
    public void Tutorial()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void S1()
    {
        SceneManager.LoadScene("S5-1", LoadSceneMode.Single);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
