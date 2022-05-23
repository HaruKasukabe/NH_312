using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazorController : MonoBehaviour
{
    [SerializeField] private float speed = 100; //e’e‚ÌƒXƒs[ƒh

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
        Vector3 lazerPos = transform.position; //Vector3Œ^‚ÌplayerPos‚ÉŒ»İ‚ÌˆÊ’uî•ñ‚ğŠi”[
        lazerPos.x += speed * Time.deltaTime; //xÀ•W‚Éspeed‚ğ‰ÁZ
        transform.position = lazerPos; //Œ»İ‚ÌˆÊ’uî•ñ‚É”½‰f‚³‚¹‚é


    }
    public void LineUpdate()
    {
        count++;
        line.positionCount = count;
        line.SetPosition(count - 1, transform.position);
    }
}
