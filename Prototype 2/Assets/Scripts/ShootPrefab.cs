/*
 * (Luke Hensley)
 * (Prototype 2)
 * (Fires projectile)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPrefab : MonoBehaviour
{
    public GameObject prefab;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.transform.position, prefab.transform.rotation);
        }
    }
}
