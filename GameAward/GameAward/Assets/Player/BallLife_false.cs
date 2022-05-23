// =========================================================
//
// BallLife_false.cs[ボールが画面外または床接地で無効化]
// Author:HARUTO TAKEI
// 
// 更新履歴
// 2022/03/08:ボールが画面外または床に当たることで軌跡を無効化
// 
// =========================================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLife_false : MonoBehaviour
{
    Renderer Line_Renderer; // 判定したいオブジェクトのレンダラーへの参照
    bool flg = false;

    // Start is called before the first frame update
    void Start()
    {
        Line_Renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Line_Renderer.isVisible)
            flg = true;
        if(!Line_Renderer.isVisible&&flg)
        {

            // オブジェクトが画面から消えた時
            gameObject.SetActive(false);
        }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            gameObject.SetActive(false);
        }
    }
}
