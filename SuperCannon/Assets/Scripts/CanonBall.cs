using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBall : Bullet
{
    // Start is called before the first frame update
    new void Start()
    {
        SetSpeed(10);
        GetComponent<Rigidbody2D>().gravityScale = 0.9f;
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
