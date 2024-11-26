using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortRangeBullet : Bullet
{
    // Start is called before the first frame update
    new void Start()
    {
        SetSpeed(20);
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
