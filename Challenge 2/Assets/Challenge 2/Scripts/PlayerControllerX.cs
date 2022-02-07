/*
 * (Luke Hensley)
 * (Challenge 2)
 * (Controls player functions)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public bool CanSpawn = true;
    public float spawnRate = 0.5f;
    public float nextSpawn = -1f;

    // Update is called once per frame
    void Update()
    {

        if(Time.time > nextSpawn)
        {
            CanSpawn = true;
        }
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && CanSpawn == true)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            nextSpawn = Time.time + spawnRate;

            CanSpawn = false;
        }
    }
}
