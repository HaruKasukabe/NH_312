//=================================
//Author:Ryo Tokuda
//çXêVóöó: 2022/03/28
//================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{
    public void Tutorial()
    {
        FadeManager.Instance.LoadScene("SampleScene", 0.5f);
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void S1()
    {
        FadeManager.Instance.LoadScene("S5-1", 0.5f);
        SceneManager.LoadScene("S5-1", LoadSceneMode.Single);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
