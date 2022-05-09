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


   public int shotCount = 17; //�C���N�̐�

    void Start()
    {
        Fade = GameObject.Find("FadePanel");
        script = Fade.GetComponent<Fade>();
        

        speed = 0.0f;  // �C���N�̑��x

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
                Debug.Log("�C���N�������Ȃ�܂���");
            //=���X�^�[�g=
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
            // �e�i�Q�[���I�u�W�F�N�g�j�̐���
            GameObject clone = Instantiate(ball, transform.position, Quaternion.identity);

            // �N���b�N�������W�̎擾�i�X�N���[�����W���烏�[���h���W�ɕϊ��j
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // �����̐����iZ�����̏����Ɛ��K���j
            Vector3 shotForward = Vector3.Scale((mouseWorldPos - transform.position), new Vector3(1, 1, 0)).normalized;

            // �e�ɑ��x��^����
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
            // �e�i�Q�[���I�u�W�F�N�g�j�̐���
            GameObject clone = Instantiate(ball, transform.position, Quaternion.identity);

            var h = Input.GetAxis("Horizontal2");
            var v = Input.GetAxis("Vertical2");

            float radian = Mathf.Atan2(v, h) * Mathf.Rad2Deg;

            if (radian < 0)
            {
                radian += 360;
            }

            // �����̐����iZ�����̏����Ɛ��K���j
            //Vector3 shotForward = Vector3.Scale((mouseWorldPos - transform.position), new Vector3(1, 1, 0)).normalized;

            Vector3 shotForward = new Vector3(h, -v, 0).normalized;
            Debug.Log(shotForward);
            // �e�ɑ��x��^����
            clone.GetComponent<Rigidbody2D>().velocity = shotForward * speed;

            audioSource.PlayOneShot(sound1);

            speed = 0.0f;
        }
    }
}