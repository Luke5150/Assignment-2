/*
 * (Luke Hensley)
 * (Prototype 2)
 * (Detects collison of projectile)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollison : MonoBehaviour
{
    private DisplayScore score;

    private void Start()
    {
        score = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }
    private void OnTriggerEnter(Collider other)
    {
        score.score++;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }

}
