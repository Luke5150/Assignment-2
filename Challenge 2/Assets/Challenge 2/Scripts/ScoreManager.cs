/*
 * (Luke Hensley)
 * (Challenge 2)
 * (Controls score changes)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;

    public Text scoreText;
    public GameObject winText;

 

    private void Update()
    {
        scoreText.text = "Score: " + score;

        if(score >= 5)
        {
            winText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.R))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
            }
        }

    }
}
