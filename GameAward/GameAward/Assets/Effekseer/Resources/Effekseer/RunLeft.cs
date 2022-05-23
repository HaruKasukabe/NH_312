using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Effekseer;

public class RunLeft : MonoBehaviour
{
    private EffekseerEmitter RunEffect;
    public string objectName;

    // Start is called before the first frame update
    void Start()
    {
        RunEffect = GameObject.Find(objectName).GetComponent<EffekseerEmitter>();
    }

    // Update is called once per frame
    void Update()
    {
        //=======ƒvƒŒƒCƒ„[‘€ì=============
        float x = Input.GetAxis("Horizontal");
        if (x == 0)
        {

        }
        else if (x > 0)
        {
         
        }
        else if (x < 0)
        {
            RunEffect.Play();
            if (!RunEffect.exists)
            {
                RunEffect.StopRoot();
            }
        }
    }
}
