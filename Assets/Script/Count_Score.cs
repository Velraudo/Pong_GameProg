using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Count_Score : MonoBehaviour
{
    public Text ScoreBoard;
    public GameObject ball;

    private int Player1_Score = 0;
    private int Player2_Score = 0;
    private bool isScored = false;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        if(!isScored)
        {
            if(ball.transform.position.x >= 15f)
            {
                Player1_Score++;
                isScored = true;
            }
            
            if(ball.transform.position.x <= -15f)
            {
                Player2_Score++;
                isScored = true;
            }
        }
        else
        {
            if(ball.transform.position.x < 14f && ball.transform.position.x > -14f)
            {
                isScored = false;
            }
        }

        if(Player1_Score >= 12)
        {
            SceneManager.LoadScene(0);
        }
        if(Player2_Score >= 12)
        {
            SceneManager.LoadScene(0);
        }

        ScoreBoard.text = Player1_Score.ToString() + " - " + Player2_Score.ToString();
        // print(Player1_Score + " , " + Player2_Score);
    }
}
