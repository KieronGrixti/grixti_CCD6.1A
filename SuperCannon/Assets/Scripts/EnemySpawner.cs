using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public List<EnemySO> enemyList = new List<EnemySO>();

    //coroutine
    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            int enemychoice = Random.Range(0, enemyList.Count);
            Vector3 enemyPos = Vector3.zero; //we need to randomise this

            GameObject enemyInstance = Instantiate(enemyList[enemychoice].enemyPrefab, enemyPos, Quaternion.identity);

            yield return new WaitForSeconds(2);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
