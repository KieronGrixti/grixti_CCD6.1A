using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public int hitPoints;
    public int strength;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            if (this.gameObject.GetComponent<Enemy>().strength == 1)
            {
                Destroy(this.gameObject);
                GameData.Score += this.gameObject.GetComponent<Enemy>().hitPoints;
            }
            else if (this.gameObject.GetComponent<Enemy>().strength == 2)
            {
                this.gameObject.transform.localScale /= 1.5f;
                this.gameObject.GetComponent<Enemy>().strength -= 1;
                //GameData.Score += this.gameObject.GetComponent<Enemy>().hitPoints;
            }
        }
        else if (collision.gameObject.CompareTag("floor"))
            GameData.Health -= this.gameObject.GetComponent<Enemy>().strength;
            if (GameData.Health <= 0)
                SceneManager.LoadScene("GameOver");

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
