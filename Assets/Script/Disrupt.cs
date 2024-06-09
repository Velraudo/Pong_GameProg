using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disrupt : MonoBehaviour
{
    private float D_Speed = 9f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(D_Speed, D_Speed);
        StartCoroutine(D_Pause());
    }

    IEnumerator D_Pause()
    {
        int dir_X = Random.Range(-1, 2);
        int dir_Y = Random.Range(-1, 2);

        if(dir_X == 0)
        {
            dir_X = 1;
        }

        rb.velocity = new Vector2(0f, 0f);
        yield return new WaitForSeconds(0);
        rb.velocity = new Vector2(D_Speed * dir_X, D_Speed * dir_Y);
    }
}
