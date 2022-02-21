/*
 * (Luke Hensley)
 * (Prototype 2)
 * (Spawns obstacles)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabsToSpawn;

    public HealthSystem health;

    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnPointZ = 20;

    public bool gameOver = false;


    private void Start()
    {
        health = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
        StartCoroutine(spawnCoroutine()); 
    }

    IEnumerator spawnCoroutine()
    {
        yield return new WaitForSeconds(3f);

        while(!health.gameOver)
        {
            spawn();

            float randomDelay = Random.Range(1.5f, 3.0f);

            yield return new WaitForSeconds(randomDelay);
        }
    }
   


    void spawn()
    {
        int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPointZ);

        Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);
    }
}
