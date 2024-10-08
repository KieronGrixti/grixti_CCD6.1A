using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{

    public GameObject BallPrefab; //variable declaration

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //0 means left-click , 1 means right-click
        {
            Vector3 mousePosition = Input.mousePosition; //get mouse location

            //convert from screen space to world space
            Vector3 inWorldSpace = Camera.main.ScreenToWorldPoint(mousePosition);

            //spawn a ball using a prefab
            Instantiate(BallPrefab, inWorldSpace, Quaternion.identity);

        }
    }
}
