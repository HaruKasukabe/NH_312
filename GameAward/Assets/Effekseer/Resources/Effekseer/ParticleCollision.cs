using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
    /// <summary>
    /// パーティクルが他のGameObject(Collider)に当たると呼び出される
    /// </summary>
    /// <param name="other"></param>   
    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.CompareTag("Sprincler"))
        {
            GetComponent<Collider>().isTrigger = false; // Triggerをfalseにする。
            GetComponent<Renderer>().material.color = other.GetComponent<Renderer>().material.color + new Color32(255, 0, 0, 0);
            //other.gameObject.SetActive(false);    //これをオンにすると、一つでもスプリンクラーのエフェクトが床(Floor)にぶつかった瞬間に消える。
            Debug.Log("Sprincler");
        }
    }
}