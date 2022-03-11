//=============================================================================
//
// インクの処理 [Bullet.cs]
// Author : 
//
// 更新履歴
// 2023/03/08 インクを飛ばす軌跡に破線を追加 (武井 遥都)
// 
//=============================================================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 direction;
    private Transform thisTransform;

    LineRenderer line; // インクの軌跡用のコンポーネントを受ける変数
    int count; // 線の頂点の数

    void Start()
    {
        thisTransform = transform;
        line = GetComponent<LineRenderer>(); // LineRendererコンポーネントを取得
    }

    void Update()
    {
        Vector3 newPosition;
        newPosition = thisTransform.position + new Vector3(direction.x * Time.deltaTime, direction.y * Time.deltaTime, 0);
       // transform.SetPosition(newPosition.x, newPosition.y, newPosition.z);
    }

    // GetVectorはおそらく発射後に使うため、分けたほうが良いと考える
    public void LineUpdate(Vector3 from, Vector3 to)
    {
        direction = new Vector3(to.x - from.x, to.y - from.y, to.z - from.z);
        count ++; // 頂点数を1つずつ増やす
        line.positionCount = count; // 頂点数の更新
        line.SetPosition(count - 1, transform.position); // オブジェクトの位置情報をセット
        /* Unityの調子が悪くデバックできてません。
           https://note.com/macgyverthink/n/n3278ee335850
           ↑参考サイト
         */ 
    }

    public void getVector(Vector3 from, Vector3 to)
    {
        direction = new Vector3(to.x - from.x, to.y - from.y, to.z - from.z);
    }
}
