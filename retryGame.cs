﻿using UnityEngine;
using System.Collections;
// 追加
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class retryGame : MonoBehaviour
{

    public GameObject player;
    public GameObject OnPanel, OnUnPanel;
    private bool pauseGame = false;

    void Start()
    {
        OnUnPause();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseGame = !pauseGame;

            if (pauseGame == true)
            {
                OnPause();
            }
            else
            {
                OnUnPause();
            }
        }
    }

    public void OnPause()
    {
        OnPanel.SetActive(true);        // PanelMenuをtrueにする
        OnUnPanel.SetActive(false);     // PanelEscをfalseにする
        Time.timeScale = 0;
        pauseGame = true;
        FirstPersonController fpc = player.GetComponent<FirstPersonController>();
        fpc.enabled = false;

        Cursor.lockState = CursorLockMode.None;     // 標準モード
        Cursor.visible = true;    // カーソル表示
    }

    public void OnUnPause()
    {
        OnPanel.SetActive(false);       // PanelMenuをfalseにする
        OnUnPanel.SetActive(true);      // PanelEscをtrueにする
        Time.timeScale = 1;
        pauseGame = false;
        FirstPersonController fpc = player.GetComponent<FirstPersonController>();
        fpc.enabled = true;

        Cursor.lockState = CursorLockMode.Locked;   // 中央にロック
        Cursor.visible = false;     // カーソル非表示
    }

    public void OnRetry()
    {
        SceneManager.LoadScene("Config");
    }

    public void OnResume()
    {
        OnUnPause();
    }
}
