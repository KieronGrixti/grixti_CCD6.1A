using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public List<EnemySO> enemyList = new List<EnemySO>();

    int XMin, XMax, YMax;

    //coroutine
    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            int enemychoice = Random.Range(0, enemyList.Count);
            //Vector3 enemyPos = Vector3.zero; //we need to randomise this
            Vector3 enemyPos = new Vector3(Random.Range(XMin + 1,XMax - 1),YMax - 3);

            GameObject enemyInstance = Instantiate(enemyList[enemychoice].enemyPrefab, enemyPos, Quaternion.identity);


            //Here we are copying data from the scriptable object to the instance
            enemyInstance.GetComponent<Enemy>().hitPoints = enemyList[enemychoice].hitPoints;
            enemyInstance.GetComponent<Enemy>().strength = enemyList[enemychoice].strength;

            yield return new WaitForSeconds(2);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        XMin = (int) GameObject.Find("LeftWall").transform.position.x;
        XMax = (int)GameObject.Find("RightWall").transform.position.x;
        YMax = (int)GameObject.Find("TopWall").transform.position.y;

        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
