using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear : MonoBehaviour
{
    public GameObject ClearImage;
    GameObject Goal;

    // Start is called before the first frame update
    void Start()
    {
        Goal = GameObject.FindWithTag("Goal");

        Debug.Log("Name:" + Goal.name);
    }

    // Update is called once per frame
    void Update()
    {
        Goal = GameObject.FindWithTag("Goal");
        if(Goal != null)
        {
            Debug.Log("��޼ު��");
        }
        if (Goal == null)
        {
            ClearImage.gameObject.SetActive(true);
            Debug.Log("�ر");
        }
    }
}
