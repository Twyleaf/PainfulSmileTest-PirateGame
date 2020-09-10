using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemyShipTypes;
    public Transform[] spawners;
    public float spawnTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        spawnTime = GameplayParameters.enemySpawnRate;
        InvokeRepeating("SpawnEnemy", 0f, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        int spawnPointIndex = Random.Range(0, spawners.Length);
        int enemyIndex = Random.Range(0, enemyShipTypes.Length);
        GameObject enemyObject = Instantiate(enemyShipTypes[enemyIndex], spawners[spawnPointIndex].position, spawners[spawnPointIndex].rotation);
    }
}
