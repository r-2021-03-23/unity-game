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

    public void level1_2()
    {
        SceneManager.LoadScene("game-level1-normal");
    }

    public void level1_3()
    {
        SceneManager.LoadScene("game-level1-hard");
    }

    public void level2_1()
    {
        SceneManager.LoadScene("game-level1-simple");
    }

    public void level2_2()
    {
        SceneManager.LoadScene("game-level2-normal");
    }
    public void level2_3()
    {
        SceneManager.LoadScene("game-level2-hard");
    }
    public void level3_1()
    {
        SceneManager.LoadScene("game-level2-simple");
    }
    public void level3_2()
    {
        SceneManager.LoadScene("game-level3-normal");
    }
    public void level3_3()
    {
        SceneManager.LoadScene("game-level1-hard");
    }
}
