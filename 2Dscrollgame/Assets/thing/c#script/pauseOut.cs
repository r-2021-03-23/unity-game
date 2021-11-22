using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pauseOut: MonoBehaviour
{
    public GameObject pause,pauseMenu;
    
    public static bool isGamePaused = false;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(isGamePaused == true)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
        if(Input.GetKeyDown(KeyCode.JoystickButton9))
        {
            if(isGamePaused)
            {
                clickPaused();
                Time.timeScale = 0f;  
            }
            else
            {
                clickResume();
                Time.timeScale = 1f;  
            }
        }
    }

     public void clickPaused()
    {   
        pauseMenu.SetActive(true);
        pause.SetActive(false);
        isGamePaused = true;
    }

    public void clickResume()
    {
        pauseMenu.SetActive(false);
        pause.SetActive(true);
        isGamePaused = false;  
    }
    public void clickMenu()
    {
        SceneManager.LoadScene("gameStart");
    }
}
