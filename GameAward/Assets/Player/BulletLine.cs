using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLine : MonoBehaviour
{
    public GameObject ball_line;
    float speed;

    public AudioClip sound1;

    void Start()
    {
        speed = 30.0f;  // 弾の速度

    }

    // Update is called once per frame
    void Update()
    {
        // 右クリックでインクの軌跡を出す
        if (Input.GetMouseButtonDown(1) || Input.GetKeyDown("joystickbutton4"))
        {
            // 弾（ゲームオブジェクト）の生成
            GameObject clone = Instantiate(ball_line, transform.position, Quaternion.identity);

            // クリックした座標の取得（スクリーン座標からワールド座標に変換）
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // 向きの生成（Z成分の除去と正規化）
            Vector3 shotForward = Vector3.Scale((mouseWorldPos - transform.position), new Vector3(1, 1, 0)).normalized;

            // 弾に速度を与える
            clone.GetComponent<Rigidbody2D>().velocity = shotForward * speed;

        }
    }

}
