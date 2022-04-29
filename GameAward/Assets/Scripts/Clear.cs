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
        Goal = GameObject.FindWithTag("goalAnim");
        GoalNum = 0;

        Debug.Log("Name:" + Goal.name);
    }

    // Update is called once per frame
    public void Update()
    {
        if (GoalNum > 0)
        {
            ClearImage.gameObject.SetActive(true);
            Goal.GetComponent<Animator>().SetBool("clear", true);
            playerAnimation.playerAnim.GetComponent<Animator>().SetTrigger("goal");
        }
    }

    public void PainNumPlus()
    {
        GoalNum += 1;
    }
}
