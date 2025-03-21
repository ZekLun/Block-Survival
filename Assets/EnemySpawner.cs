using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] EnemyPrefabs;
    public float spawnRate = 1f;
    private bool isSpawning = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        WaitForSeconds wait = new(spawnRate);

        while (isSpawning)
        {
            yield return wait;
            int rand = Random.Range(0, EnemyPrefabs.Length);
            GameObject enemyToSpawn = EnemyPrefabs[rand];

            Instantiate(enemyToSpawn, transform.position, Quaternion.identity);
        }
    }
}
