using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour
{
    private AudioSource sound1;
    // Start is called before the first frame update
    void Start()
    {
        sound1 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            sound1.PlayOneShot(sound1.clip);
        }
    }
}
