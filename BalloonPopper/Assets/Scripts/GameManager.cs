using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject balloonPrefab;

    //method to spawn the balloons
    IEnumerator SpawnBalloons()
    {
        while (true)
        {
            Vector3 balloonPos = new Vector3 (0, balloonPrefab.transform.position.y , 0);
            Instantiate(balloonPrefab, balloonPos, Quaternion.identity);
            yield return new WaitForSeconds(2); //wait 2 seconds
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBalloons());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
