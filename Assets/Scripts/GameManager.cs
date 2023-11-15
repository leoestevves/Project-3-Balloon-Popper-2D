using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject balloon;
    [SerializeField] Transform spawnPoint;

    [SerializeField] float maxX;

    [SerializeField] float spawnFirstDelay;
    [SerializeField] float spawnUpdateDelay;

    [SerializeField] private BalloonController _balloonController;

    int playerScore = 0;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBalloon", spawnFirstDelay, spawnUpdateDelay);        
    }

    // Update is called once per frame
    void Update()
    {

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
        Debug.Log(playerScore);
    }

    
}
