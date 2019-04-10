using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject FastEnemy;

    private float spawnRadius;
    public float startSpawnRadius;
    public float timeBetweenSpawn = 3f;
    public float timeBetweenSpawnFast = 3f;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
        StartCoroutine(SpawnFast());
        spawnRadius = startSpawnRadius;
    }


    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(timeBetweenSpawn);
        SpawnEnemy();
        StartCoroutine(Spawn());

    }

    IEnumerator SpawnFast()
    {
        yield return new WaitForSeconds(timeBetweenSpawnFast);
        SpawnFastEnemy();
        StartCoroutine(SpawnFast());

    }

    void SpawnEnemy()
    {
        Vector2 spawnPos = PlayerController.position;
        spawnPos = Random.insideUnitCircle.normalized * spawnRadius;
        Instantiate(Enemy, spawnPos, Quaternion.identity);
    }

    void SpawnFastEnemy()
    {
        Vector2 spawnPos = PlayerController.position;
        spawnPos = Random.insideUnitCircle.normalized * spawnRadius;
        Instantiate(FastEnemy, spawnPos, Quaternion.identity);
    }
}

   
