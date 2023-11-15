using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject balloon;
    [SerializeField] Transform spawnPoint;

    [SerializeField] float maxX;

    [SerializeField] float spawnFirstDelay;
    [SerializeField] float spawnUpdateDelay;

    [SerializeField] private BalloonController _balloonController;

    int playerScore = 0;

    [SerializeField] TextMeshProUGUI scoreText;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBalloon", spawnFirstDelay, spawnUpdateDelay);        
    }


    void SpawnBalloon()
    {
        Vector2 spawnPos = spawnPoint.position;
        spawnPos.x = Random.Range(-maxX, maxX);

        Instantiate(balloon, spawnPos, Quaternion.identity);
    }

    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    
}
