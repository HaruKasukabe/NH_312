using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
    /// <summary>
    /// �p�[�e�B�N��������GameObject(Collider)�ɓ�����ƌĂяo�����
    /// </summary>
    /// <param name="other"></param>   
    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.CompareTag("Sprincler"))
        {
            GetComponent<Collider>().isTrigger = false; // Trigger��false�ɂ���B
            GetComponent<Renderer>().material.color = other.GetComponent<Renderer>().material.color + new Color32(255, 0, 0, 0);
            //other.gameObject.SetActive(false);    //������I���ɂ���ƁA��ł��X�v�����N���[�̃G�t�F�N�g����(Floor)�ɂԂ������u�Ԃɏ�����B
            Debug.Log("Sprincler");
        }
    }
}