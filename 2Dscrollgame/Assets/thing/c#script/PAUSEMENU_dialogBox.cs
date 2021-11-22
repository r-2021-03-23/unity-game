using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class PAUSEMENU_dialogBox : MonoBehaviour
{
    public GameObject pause,pauseMenu,resume;

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

        if(Input.GetKeyDown(KeyCode.Joystick1Button9))
        {
            clickPaused();
            
        }
        if(Input.GetKeyDown(KeyCode.Joystick1Button7))
        {
            clickResume();
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
    }
}
