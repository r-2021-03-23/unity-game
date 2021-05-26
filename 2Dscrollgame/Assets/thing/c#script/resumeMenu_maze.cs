using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resumeMenu_maze: MonoBehaviour
{
   
    public GameObject pause;
    
 
    void Start()
    {
        gameObject.SetActive(false);
        pause.SetActive(true);
        
    }
    public void clickPaused()
    {
        Time.timeScale = 0;
        pause.SetActive(false);
        gameObject.SetActive(true);
       
    }

    public void clickResume()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
        pause.SetActive(true);
        
    }

    public void clickMenu()
    {
        SceneManager.LoadScene("gameStart");
    }
}
