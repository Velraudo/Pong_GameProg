using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseGame;
    public static bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        pauseGame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();
            }else{
                GetPaused();
            }
        }
    }

    public void GetPaused()
    {
        pauseGame.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseGame.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void GoToMenu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
