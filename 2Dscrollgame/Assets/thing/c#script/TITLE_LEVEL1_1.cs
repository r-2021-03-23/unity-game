using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TITLE_LEVEL1_1: MonoBehaviour
{
    // Start is called before the first frame update
    public void GameQuit()
    {   
        Application.Quit();
    }
    public void GameStart()
    {
        SceneManager.LoadScene("game-level1SIMPLE");
    }
    
}
