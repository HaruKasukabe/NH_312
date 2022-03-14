using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Effekseer;


public class Ink : MonoBehaviour
{
    private EffekseerEmitter InkEffect;

    public string objectName;

    // Start is called before the first frame update
    void Start()
    {
        //InkEffect = GameObject.Find("Ink").GetComponent<EffekseerEmitter>();
        InkEffect = GameObject.Find(objectName).GetComponent<EffekseerEmitter>();

        // �G�t�F�N�g���擾����B
        EffekseerEffectAsset effect = Resources.Load<EffekseerEffectAsset>("Ink");
        // transform�̈ʒu�ŃG�t�F�N�g���Đ�����
        EffekseerHandle handle = EffekseerSystem.PlayEffect(effect, transform.position);
        // transform�̉�]��ݒ肷��B
        handle.SetRotation(transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            InkEffect.Play();
        }
    }
}