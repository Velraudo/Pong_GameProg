using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_Control : MonoBehaviour
{
    [SerializeField]
    private float _speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2 (-14, 0);
    }

    // Update is called once per frame
    void Update()
    {
        CalcMovement();
    }

    void CalcMovement()
    {
        // P1 MOVEMENT
        // float V_Input = Input.GetAxis("Vertical");
        float V_Input = 0f;

        if(Input.GetKey(KeyCode.W))
        {
            V_Input = 1f;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            V_Input = -1f;
        }
        transform.Translate(Vector2.up * V_Input * _speed * Time.deltaTime);

        // P1 AREA BOUNDERIES
        transform.position = new Vector2(-14, Mathf.Clamp(transform.position.y, -9f, 7.5f));
    }
}
