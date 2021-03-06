using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazorController : MonoBehaviour
{
    [SerializeField] private float speed = 100; //銃弾のスピード

    LineRenderer line;
    int count;

    void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        LineUpdate();
    }

    public void Move()
    {
        Vector3 lazerPos = transform.position; //Vector3型のplayerPosに現在の位置情報を格納
        lazerPos.x += speed * Time.deltaTime; //x座標にspeedを加算
        transform.position = lazerPos; //現在の位置情報に反映させる


    }
    public void LineUpdate()
    {
        count++;
        line.positionCount = count;
        line.SetPosition(count - 1, transform.position);
    }
}
