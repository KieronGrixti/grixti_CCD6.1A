using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) 
            //Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);

        else if (collision.gameObject.CompareTag("Enemy"))
            //Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);
    }
}
