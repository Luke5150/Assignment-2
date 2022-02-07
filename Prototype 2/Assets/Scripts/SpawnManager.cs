/*
 * (Luke Hensley)
 * (Prototype 2)
 * (Spawns animals randomly)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animals;

    private float leftBound = -14;
    private float rightbound = 14;
    private float spawnZ = 20;

    public HealthSystem health;

    private void Start()
    {
        health = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
        StartCoroutine(spawnAnimalCoroutine()); 
    }

  

    void spawnAnimals()
    {
        int index = Random.Range(0, animals.Length);

        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightbound), 0, spawnZ);

        Instantiate(animals[index], spawnPos, animals[index].transform.rotation);
    }

    IEnumerator spawnAnimalCoroutine()
    {
        yield return new WaitForSeconds(3f);

        while(!health.gameOver)
        {
            spawnAnimals();

            float randomDelay = Random.Range(0.8f, 2.0f);
            yield return new WaitForSeconds(randomDelay);
        }
    }
}
