using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public GameObject pause;
    
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()   
    {
        if(player.isGameOver == true)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void restart()
    {
        SceneManager.LoadScene(sceneName);
        player.isGameOver = false;
        
    }
    public void menu()
    {
        SceneManager.LoadScene("UILEVEL");
    }

    public void quit()
    {
        Application.Quit();
    }
    

}
