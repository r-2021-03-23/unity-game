using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TITLE_LEVEL1_1: MonoBehaviour
{
    public GameObject text;
    

    void start()
    {
        
    }
    
    public void GameQuit()
    {   
        Application.Quit();
    }
    public void GameStart()
    {
        SceneManager.LoadScene("UILevel");
    }
    
    public void backButton()
    {
        SceneManager.LoadScene("GameStart");
    }
    
    public void level1_1()
    {
        SceneManager.LoadScene("game-level1-simple");
    }

}
