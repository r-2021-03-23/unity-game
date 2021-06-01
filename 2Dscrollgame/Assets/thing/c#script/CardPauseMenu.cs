using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CardPauseMenu : MonoBehaviour
{
    
    public GameObject pause;
    public GameObject button;

    
    void Update()
    {
        
    }
    void Start()
    {
        gameObject.SetActive(false);
        pause.SetActive(true);
        button.SetActive(true);
        
    }
    public void clickPaused()
    {
        Time.timeScale = 0;
        pause.SetActive(false);
        gameObject.SetActive(true);
        button.SetActive(false);
    }

    public void clickResume()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
        pause.SetActive(true);
        button.SetActive(true);
    }

    public void clickMenu()
    {
        SceneManager.LoadScene("gameStart");
    }

}
