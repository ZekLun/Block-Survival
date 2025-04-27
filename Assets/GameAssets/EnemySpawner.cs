using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] EnemyPrefabs;
    public float spawnRate = 8;
    private readonly bool isSpawning = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        while (isSpawning)
        {
            float randomSpawn = Random.Range(1, 15);
            yield return new WaitForSeconds(spawnRate + randomSpawn);

            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        int randomEnemy = Random.Range(0, EnemyPrefabs.Length);
        GameObject enemyToSpawn = EnemyPrefabs[randomEnemy];

        Instantiate(enemyToSpawn, transform.position, Quaternion.identity);
    }
}
