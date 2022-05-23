//==================================================
// SelectStage.cs[ステージ選択画面のプレイヤーの移動]
//Author: RYO TOKUDA
//更新履歴: 2022/03/28
//=================================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //シーン遷移させるために必要

public class SelectStage : MonoBehaviour
{
    //スタートと終わりの目印
    public Transform startMarker;
    public Transform endMarker;
    private float speed = 1.0f;       //プレイヤーのスピード

    //二点間の距離を入れる
    private float distance_two;

    private SpriteRenderer renderer;  //プレイヤーを反転させるやつ

    void Start()
    {
       
    }
    void Update()
    {
        // 現在の位置
        float present_Location = (Time.time * speed) / distance_two;

        // オブジェクトの移動
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, present_Location);
         
        Vector2 position = transform.position;
        float x = Input.GetAxis("Horizontal");

        if (Input.GetKey("left"))
        {
            position.x -= speed;
            renderer.flipX = true;
        }
        else if (Input.GetKey("right"))
        {
            position.x += speed;
            renderer.flipX = false;
        }
        else if (Input.GetKey("up"))
        {
            position.y += speed;
        }
        else if (Input.GetKey("down"))
        {
            position.y -= speed;
        }

        transform.position = position;
    }

     void OnTriggerEnter2D(Collider2D  collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}


  /* //--------マウス操作移動↓--------
   private Vector3 mouse;
    private Vector3 target;

    void Update()
    {
        mouse = Input.mousePosition;
        target = Camera.main.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, 10));
        //target.y = transform.position.y;
        this.transform.position = target;
    }
    
}
*/