using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
    public float upSpeed;
    int score = 0;

    AudioSource audioSource;
    SpriteRenderer spriteRenderer;
    CircleCollider2D _collider2D;

    private IEnumerator coroutine;

    //private IEnumerator BalloonDestruction;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        _collider2D = GetComponent<CircleCollider2D>();
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
        coroutine = BalloonDestruction();
        StartCoroutine(coroutine);
    }

    IEnumerator BalloonDestruction()
    {
        spriteRenderer.enabled = false;
        _collider2D.enabled = false;
        yield return new WaitForSeconds(0.3f);
        Destroy(gameObject);
    }


}
