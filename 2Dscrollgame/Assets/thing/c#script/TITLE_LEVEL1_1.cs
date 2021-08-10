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
    public void level1_simple()
    {
        SceneManager.LoadScene("game-level1-simple");
    }

    public void level1_normal()
    {
        if( CardGameManager.f == 1)
        {
            SceneManager.LoadScene("game-level1-normal");
        }
        else
        {
            text.SetActive(true);
        }
    }

    public void level1_hard()
    {
        if(mazeGameManager.m == 1)
        {
            SceneManager.LoadScene("game-level1-hard");
        }
        else
        {
            text.SetActive(true);
        }
    }

    public void level2_simple()
    {
        if(snakeGame_snake.s == 1)
        {
            SceneManager.LoadScene("game-level2-simple");
        }
        else
        {
            text.SetActive(true);
        }
    }

}
