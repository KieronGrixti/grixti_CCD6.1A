using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour, IPoppable
{
    public void onPop()
    {
        Destroy(gameObject);
        //call Game Manager increment score
        GameManager.Instance.IncrementScore();
    }

    void OnMouseDown()
    {
        onPop();
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
