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
        if(player.xy >= 2)
        {
             SceneManager.LoadScene("game-level1-normal");
        }
        else
        {
            text.SetActive(true);
        }
    }

    public void level1_3()
    {
        if(player.xy >= 3)
        {
            SceneManager.LoadScene("game-level1-hard");
        }
        else
        {
            text.SetActive(true);
        }
    }

    public void level2_1()
    {
        if(player.xy >= 4)
        {
            SceneManager.LoadScene("game-level2-simple");
        }
        else
        {
            text.SetActive(true);
        }
    }

    public void level2_2()
    {
        if(player.xy >=5)
        {
            SceneManager.LoadScene("game-level2-normal");
        }
        else
        {
            text.SetActive(true);
        }
        
    }
    public void level2_3()
    {
        if(player.xy >= 6)
        {
             SceneManager.LoadScene("game-level2-hard");
        }
        else
        {
            text.SetActive(true);
        }
       
    }
    public void level3_1()
    {
        if(player.xy >= 7)
        {
            SceneManager.LoadScene("game-level2-simple");
        }
        else
        {
            text.SetActive(true);
        }
        
    }
    public void level3_2()
    {
        if(player.xy >= 8)
        {
            SceneManager.LoadScene("game-level3-normal");
        }
        else
        {
            text.SetActive(true);
        }
        
    }
    public void level3_3()
    {
        if(player.xy >= 9)
        {
           SceneManager.LoadScene("game-level1-hard");
        }
        else
        {
            text.SetActive(true);
        }
        
    }
}
