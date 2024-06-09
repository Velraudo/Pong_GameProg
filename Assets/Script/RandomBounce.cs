using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBounce : MonoBehaviour
{
    [SerializeField]
    private float _BSpeed = 10f;
    private Rigidbody2D rb;

    public GameObject P1;
    public GameObject P2;

    public AudioSource tickSource;

    // RANDOM START BOUNCE
    void Start()
    {
        tickSource = GetComponent<AudioSource>();

        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(_BSpeed, _BSpeed);

        P1 = GameObject.Find("Player_1");
        P2 = GameObject.Find("Player_2");
        StartCoroutine(Pause());
    }

    void Update()
    {
        if(Mathf.Abs(this.transform.position.x) >= 17f)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine(Pause());
        }
    }


    IEnumerator Pause()
    {
        int dirX = Random.Range(-1, 2);
        int dirY = Random.Range(-1, 2);

        if(dirX == 0)
        {
            dirX = 1;
        }

        rb.velocity = new Vector2(0f, 0f);
        yield return new WaitForSeconds(3);
        rb.velocity = new Vector2(_BSpeed * dirX, _BSpeed * dirY);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        tickSource.Play();
        
        if(collision.collider.CompareTag("Player"))
        {
            Vector2 vel;
            vel.x = rb.velocity.x;
            vel.y = rb.velocity.y + collision.collider.attachedRigidbody.velocity.y;
            vel *= 1.1f;
            rb.velocity = vel;
        }
    }

}