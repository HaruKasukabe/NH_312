//=============================================================================
//
// �C���N�̏��� [Bullet.cs]
// Author : 
//
// �X�V����
// 2023/03/08 �C���N���΂��O�Ղɔj����ǉ� (���� �y�s)
// 
//=============================================================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 direction;
    private Transform thisTransform;

    LineRenderer line; // �C���N�̋O�՗p�̃R���|�[�l���g���󂯂�ϐ�
    int count; // ���̒��_�̐�

    void Start()
    {
        thisTransform = transform;
        line = GetComponent<LineRenderer>(); // LineRenderer�R���|�[�l���g���擾
    }

    void Update()
    {
        Vector3 newPosition;
        newPosition = thisTransform.position + new Vector3(direction.x * Time.deltaTime, direction.y * Time.deltaTime, 0);
       // transform.SetPosition(newPosition.x, newPosition.y, newPosition.z);
    }

    // GetVector�͂����炭���ˌ�Ɏg�����߁A�������ق����ǂ��ƍl����
    public void LineUpdate(Vector3 from, Vector3 to)
    {
        direction = new Vector3(to.x - from.x, to.y - from.y, to.z - from.z);
        count ++; // ���_����1�����₷
        line.positionCount = count; // ���_���̍X�V
        line.SetPosition(count - 1, transform.position); // �I�u�W�F�N�g�̈ʒu�����Z�b�g
        /* Unity�̒��q�������f�o�b�N�ł��Ă܂���B
           https://note.com/macgyverthink/n/n3278ee335850
           ���Q�l�T�C�g
         */ 
    }

    public void getVector(Vector3 from, Vector3 to)
    {
        direction = new Vector3(to.x - from.x, to.y - from.y, to.z - from.z);
    }
}
