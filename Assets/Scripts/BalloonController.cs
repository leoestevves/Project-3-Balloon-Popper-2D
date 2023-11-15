using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
    public float upSpeed;
    int score = 0;

    AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Translate(0, upSpeed * Time.deltaTime, 0);
    }

    private void OnMouseDown()
    {
        score++;
        audioSource.Play();
        Debug.Log(score);
        
    }
}
