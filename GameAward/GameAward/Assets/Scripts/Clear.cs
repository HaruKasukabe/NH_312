using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear : MonoBehaviour
{
    public GameObject ClearImage;
    GameObject Goal;
    public static int GoalNum;

    // Start is called before the first frame update
    public void Start()
    {
        Goal = GameObject.FindWithTag("Goal");
        GoalNum = 0;

        Debug.Log("Name:" + Goal.name);
    }

    // Update is called once per frame
    public void Update()
    {
        //Goal = GameObject.FindWithTag("Goal");
        //if(Goal == null)
        //{
        //    Debug.Log("µÌÞ¼Þª¸Ä");
        //}
        //if (Goal != null)
        //{
        //    ClearImage.gameObject.SetActive(true);
        //    Debug.Log("¸Ø±");
        //}

        if (GoalNum > 0)
            ClearImage.gameObject.SetActive(true);
    }

    public void PainNumPlus()
    {
        GoalNum += 1;
    }
}
