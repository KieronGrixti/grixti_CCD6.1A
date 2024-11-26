using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject canonBallPrefab;
    public GameObject shortRangeBulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void PointAtMouse() //will rotate the canon to make it face the mouse
    {
        Quaternion newrotation = Quaternion.LookRotation(transform.position - GameData.Target, Vector3.forward);

        newrotation.x = 0f;
        newrotation.y = 0f;

        transform.rotation = Quaternion.Slerp(transform.rotation,newrotation,Time.deltaTime * 3f);
    }

    // Update is called once per frame
    void Update()
    {
        PointAtMouse();

        if (Input.GetMouseButtonDown(0)) //left click
        {
            Instantiate(canonBallPrefab,transform.position,transform.rotation);
        }

        if (Input.GetMouseButtonDown(1)) //right click
        {
            Instantiate(shortRangeBulletPrefab, transform.position, transform.rotation);
        }
    }
}
