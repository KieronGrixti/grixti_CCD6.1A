using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovingBox : MonoBehaviour
{
    // Start is called before the first frame update
    float xMin, yMin, xMax, yMax;
    void Start()
    {
        Vector3 topLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0));
        Vector3 topRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));
        Vector3 bottomLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector3 bottomRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));

        xMin = topLeft.x + 0.5f; //or bottomLeft.x
        xMax = topRight.x - 0.5f; // or bottomRight.x
        yMin = bottomRight.y + 0.5f; // or bottomRight.y
        yMax = topLeft.y - 0.5f; // or topRight.y
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            float newXPosition = Mathf.Clamp(this.transform.position.x + 1, xMin, xMax);

            this.transform.position = new Vector3(newXPosition,
                                                  this.transform.position.y,
                                                  this.transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            float newXPosition = Mathf.Clamp(this.transform.position.x - 1, xMin, xMax);

            this.transform.position = new Vector3(newXPosition,
                                                 this.transform.position.y,
                                                 this.transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            float newYPosition = Mathf.Clamp(this.transform.position.y + 1, yMin, yMax);

            this.transform.position = new Vector3(this.transform.position.x,
                                                 newYPosition,
                                                 this.transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            float newYPosition = Mathf.Clamp(this.transform.position.y - 1, yMin, yMax);

            this.transform.position = new Vector3(this.transform.position.x,
                                                 newYPosition,
                                                 this.transform.position.z);
        }
    }
}
