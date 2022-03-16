using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazorController : MonoBehaviour
{
    [SerializeField] private float speed = 100; //�e�e�̃X�s�[�h

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
        Vector3 lazerPos = transform.position; //Vector3�^��playerPos�Ɍ��݂̈ʒu�����i�[
        lazerPos.x += speed * Time.deltaTime; //x���W��speed�����Z
        transform.position = lazerPos; //���݂̈ʒu���ɔ��f������


    }
    public void LineUpdate()
    {
        count++;
        line.positionCount = count;
        line.SetPosition(count - 1, transform.position);
    }
}
