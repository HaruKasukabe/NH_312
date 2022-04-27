using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallShooter : MonoBehaviour
{
    GameObject Fade;
    Fade script;

    public GameObject ball;
    float speed;

    bool attackable = true;

    public AudioClip sound1;
    AudioSource audioSource;

    [SerializeField] static string bullet;


   public int shotCount = 17; //インクの数

    void Start()
    {
        Fade = GameObject.Find("FadePanel");
        script = Fade.GetComponent<Fade>();
        

        speed = 0.0f;  // インクの速度

        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    { 
            if (shotCount < 1)
            {
               
                if(shotCount == 0)
                {
                    attackable = false;
                }
                Debug.Log("インクが無くなりました");
            //=リスタート=
                  SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            script.isFadeout = true;

        }
    
        if (Input.GetMouseButton(0))
        {
            speed += 0.1f;

            //shotCount -= 1;
        }
     if (attackable == true)
        {

        if(Input.GetMouseButtonUp(0))
        {
            // 弾（ゲームオブジェクト）の生成
            GameObject clone = Instantiate(ball, transform.position, Quaternion.identity);

            // クリックした座標の取得（スクリーン座標からワールド座標に変換）
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // 向きの生成（Z成分の除去と正規化）
            Vector3 shotForward = Vector3.Scale((mouseWorldPos - transform.position), new Vector3(1, 1, 0)).normalized;

            // 弾に速度を与える
            clone.GetComponent<Rigidbody2D>().velocity = shotForward * speed;

            audioSource.PlayOneShot(sound1);

            speed = 0.0f;
            shotCount -= 1;
        }

    }
    
        if (Input.GetKey("joystick button 7"))
        {
            speed += 0.1f;
            shotCount -= 1;
        }
        if(Input.GetKeyUp("joystick button 7"))
        {
            // 弾（ゲームオブジェクト）の生成
            GameObject clone = Instantiate(ball, transform.position, Quaternion.identity);

            var h = Input.GetAxis("Horizontal2");
            var v = Input.GetAxis("Vertical2");

            float radian = Mathf.Atan2(v, h) * Mathf.Rad2Deg;

            if (radian < 0)
            {
                radian += 360;
            }

            // 向きの生成（Z成分の除去と正規化）
            //Vector3 shotForward = Vector3.Scale((mouseWorldPos - transform.position), new Vector3(1, 1, 0)).normalized;

            Vector3 shotForward = new Vector3(h, -v, 0).normalized;
            Debug.Log(shotForward);
            // 弾に速度を与える
            clone.GetComponent<Rigidbody2D>().velocity = shotForward * speed;

            audioSource.PlayOneShot(sound1);

            speed = 0.0f;
        }
    }
}