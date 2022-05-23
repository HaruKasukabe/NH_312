using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public Button FirstSelectButton;
    void Start()
    {
       FirstSelectButton.Select();
    }
    
    void Update()
    {
        Button MenuButton = GetComponent<Button>();    // 対象のボタン
        MenuButton.animator.SetTrigger("Highlighted");
        
    }
}
