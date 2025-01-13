using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed;

    public float GetSpeed()
    {
        { return speed; }
    }

    public void SetSpeed(float speed)
    { this.speed = speed; }

    // Start is called before the first frame update
    public void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * speed;
    }
    public void OnEnable()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
