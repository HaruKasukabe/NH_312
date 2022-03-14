using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Effekseer;

public class Bird : MonoBehaviour
{
    private EffekseerEmitter BirdEffect;
    public string objectName;

    float seconds;

    void Start()
    {
        BirdEffect = GameObject.Find(objectName).GetComponent<EffekseerEmitter>();
    }

    void Update()
    {
            // Do anything
            seconds += Time.deltaTime;
            if (seconds >= 2)
            {
                BirdEffect.Play();
                if (!BirdEffect.exists)
                {
                    BirdEffect.StopRoot();
                }
                seconds = 0;
            }
    }
}
