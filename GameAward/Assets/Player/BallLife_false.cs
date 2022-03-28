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
