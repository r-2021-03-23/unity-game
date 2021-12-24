using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pauseOut: MonoBehaviour
{
    public GameObject pause,pauseMenu,resume;
    
    public GameObject[] things;
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
            for(int i = 0;i<things.Length;i++)
            {
                things[i].SetActive(false);
            }
        }
        else
        {
            Time.timeScale = 1f;
            for(int i = 0;i<things.Length;i++)
            {
                things[i].SetActive(true);
            }
        }

         if(Input.GetKeyDown(KeyCode.Joystick1Button7))
        {
            if(player.isGameOver == false) clickPaused();
            
        }
        if(Input.GetKeyDown(KeyCode.Joystick1Button5))
        {
            if(player.isGameOver == false) clickResume();
        }
        if(Input.GetKeyDown(KeyCode.Joystick1Button9))
        {
            if(player.isGameOver == false) clickMenu();
        }
    }

     public void clickPaused()
    {   
        pauseMenu.SetActive(true);
        pause.SetActive(false);
        resume.SetActive(true);
        isGamePaused = true;
    }

    public void clickResume()
    {
        pauseMenu.SetActive(false);
        pause.SetActive(true);
        resume.SetActive(false);
        isGamePaused = false;  
    }
    public void clickMenu()
    {
        SceneManager.LoadScene("gameStart");
        isGamePaused = false;
    }
}
