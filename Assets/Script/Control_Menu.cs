using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control_Menu : MonoBehaviour
{
    public Button Play_Button;
    public Button Quit_Button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play_Pong()
    {
        SceneManager.LoadScene(1);
    }

    public void DPlay_Pong()
    {
        SceneManager.LoadScene(2);
    }

    public void Bye_Pong()
    {
        Application.Quit();
    }
}
