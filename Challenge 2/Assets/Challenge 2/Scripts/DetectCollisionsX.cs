/*
 * (Luke Hensley)
 * (Challenge 2)
 * (Detects collisons)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private ScoreManager manager;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("ScoreController").GetComponent<ScoreManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        manager.score++;
      Destroy(gameObject);
    }
}
