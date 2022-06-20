using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{

    public GameObject  EnemyToSpawn;
    public bool canSpawn = true;
    public float enemySpawnTimer = 1;
    public float maxX = 30;
    public float startingY = 15;
    float randomx;
 
    // Start is called before the first frame update
    void Start()
    {
       
        StartCoroutine(SpawnEnemyTimer());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnEnemyTimer()
    {
        while (canSpawn==true)
        {
            spawnEnemy();
            yield return new WaitForSeconds(enemySpawnTimer);
        }
    }

    void spawnEnemy()
    {
        
        randomx = Random.Range(-maxX, maxX);
        Instantiate(EnemyToSpawn, new Vector3(randomx, startingY, 0), Quaternion.identity);

    }

}