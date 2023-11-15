using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BalloonController : MonoBehaviour
{
    public float upSpeed;

    AudioSource audioSource;
    SpriteRenderer spriteRenderer;
    CircleCollider2D _collider2D;

    private IEnumerator coroutine;

    private GameManager _GameManager;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        _collider2D = GetComponent<CircleCollider2D>();
    }

    private void Start()
    {
        _GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }


    private void FixedUpdate()
    {
        transform.Translate(0, upSpeed * Time.deltaTime, 0);
        Restart();
    }

    private void OnMouseDown()
    {
        _GameManager.addScore(1);
        audioSource.Play();
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

    private void Restart()
    {
        if(transform.position.y >= 6f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }        
    }
}
