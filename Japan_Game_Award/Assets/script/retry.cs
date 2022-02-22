using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retry : MonoBehaviour
{
    public GameObject Cube;
    public float force;
    public float upAdjustment;

    private void Update()
    {

        if (Input.GetKeyDown("joystick button 0"))
        {
            SceneManager.LoadScene(0);
            Debug.Log("Šª‚«–ß‚µ‚Ü‚µ‚½");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
            Debug.Log("Šª‚«–ß‚µ‚Ü‚µ‚½");
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
}
