//==============================
//更新者: Ryo Tokuda
//更新履歴:2022/04/03 スコア変数を作って全部集めたらクリアシーンに移るようにしました
//===================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class paincollision : MonoBehaviour
{
    public Text Scoretext;
    private int score = 0;

    void OnTriggerEnter2D(Collider2D collision)
    {
        score += 10;

      

        if (collision.gameObject.CompareTag("ink"))
        {
            GetComponent<Collider2D>().isTrigger = false;
            collision.gameObject.SetActive(false);
            Destroy(this.gameObject);

            Scoretext.text = string.Format("Score:{0}", score);
        }
        if (score == 40)   //4つ玉を取ったらステージ選択に行く
        {
            SceneManager.LoadScene("SelectScene");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
      
    }
}
