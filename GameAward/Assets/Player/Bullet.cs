//Bullet.cs 
//Author: RYO TOKUDA

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 direction;
    private Transform thisTransform;

    void Start()
    {
        thisTransform = transform;
    }

    void Update()
    {
        Vector3 newPosition;
        newPosition = thisTransform.position + new Vector3(direction.x * Time.deltaTime, direction.y * Time.deltaTime, 0);
       // transform.SetPosition(newPosition.x, newPosition.y, newPosition.z);
    }

    public void getVector(Vector3 from, Vector3 to)
    {
        direction = new Vector3(to.x - from.x, to.y - from.y, to.z - from.z);
    }
}
