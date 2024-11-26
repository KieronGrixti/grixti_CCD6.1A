using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBall : Bullet
{
    // Start is called before the first frame update
    new void Start()
    {
        SetSpeed(20);
        base.Start();
        GetComponent<Rigidbody2D>().gravityScale = 1.3f;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
