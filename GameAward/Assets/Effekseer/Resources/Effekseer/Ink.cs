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

        // エフェクトを取得する。
        EffekseerEffectAsset effect = Resources.Load<EffekseerEffectAsset>("Ink");
        // transformの位置でエフェクトを再生する
        EffekseerHandle handle = EffekseerSystem.PlayEffect(effect, transform.position);
        // transformの回転を設定する。
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