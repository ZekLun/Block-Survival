using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public List<Enemy> enemies = new();
    public int currentWave;
    public int waveValue;
    public List<GameObject> enemiesToSpawn = new();

    public Transform[] spawnLocations;
    public int spawnIndex;


    public int waveDuration;
    private float waveTimer;
    private float spawnInterval;
    private float spawnTimer;

    public List<GameObject> spawnedEnemies = new();
    // Start is called before the first frame update
    void Start()
    {
        GenerateWave();
    }

    // Update is called once per frame


    void FixedUpdate()
    {
        if (spawnTimer <= 0)
        {
            if (enemiesToSpawn.Count > 0)
            {
                GameObject enemy = (GameObject)Instantiate(enemiesToSpawn[0], spawnLocations[spawnIndex].position, Quaternion.identity);
                enemiesToSpawn.RemoveAt(0);
                spawnedEnemies.Add(enemy);
                spawnTimer = spawnInterval;
                if (spawnIndex + 1 <= spawnLocations.Length - 1)
                {
                    spawnIndex++;
                }
                else
                {
                    spawnIndex = 0;
                }
            }
            else
            {
                waveTimer = 0;
            }
        }
        else
        {
            spawnTimer -= Time.fixedDeltaTime;
            waveTimer -= Time.fixedDeltaTime;
        }
        if (waveTimer <= 0 && spawnedEnemies.Count <= 0)
        {
            currentWave++;
            GenerateWave();
        }
    }


    public void GenerateWave()
    {
        waveValue = currentWave * 5;
        GenerateEnemies();
        if (currentWave >= 4)
        {
            spawnInterval = waveDuration / enemiesToSpawn.Count + 1;
        }
        else
        {
            spawnInterval = waveDuration / enemiesToSpawn.Count;
        }
        waveTimer = waveDuration;
    }

    public void GenerateEnemies()
    {
        List<GameObject> generatedEnemies = new();
        while(waveValue > 0)
        {
            int randEnemyId = Random.Range(0, enemies.Count);
            int randEnemyCost = enemies[randEnemyId].cost;

            if (waveValue - randEnemyCost >= 0)
            {
                generatedEnemies.Add(enemies[randEnemyId].enemyPrefab);
                waveValue -= randEnemyCost;
            }
            else if (waveValue <= 0)
            {
                break;
            }

        }
        enemiesToSpawn.Clear();
        enemiesToSpawn = generatedEnemies;
    }
}


[System.Serializable]
public class Enemy
{
    public GameObject enemyPrefab;
    public int cost;
}
