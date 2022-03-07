//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using Effekseer;
//using System;

public class InkEffect : MonoBehaviour
{
    public GameObject prefabObj;

    // Start is called before the first frame update
    void Start()
    {
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
            CreateObject();
        }
    }

    void CreateObject()
    {
        GameObject obj = Instantiate(prefabObj, Vector3.zero, Quaternion.identity);
    }
}
