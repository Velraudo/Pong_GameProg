using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI_Control : MonoBehaviour
{
    public Transform Ball;
    public Transform Player_2;
    public float speed = 10f;
    private Vector2 destination;

    public void MoveToBall()
    {
        destination = new Vector2 (Player_2.transform.position.x,Ball.position.y);
        transform.position = Vector2.Lerp(Player_2.transform.position,destination,speed * Time.deltaTime);
    }

    void Update()
    {
        MoveToBall();
    }
}