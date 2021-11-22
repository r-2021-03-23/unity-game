using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pauseMenu1 : MonoBehaviour
{
    public GameObject pause;

    private int x;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(x == 0)
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
    }

    public void clickPaused()
    {   
       
        pause.SetActive(false);
        
        x = 0;
    }

    public void clickResume()
    {
        
        pause.SetActive(true);
          
        x=1;    
    }
    public void clickMenu()
    {
        SceneManager.LoadScene("gameStart");
    }
}
