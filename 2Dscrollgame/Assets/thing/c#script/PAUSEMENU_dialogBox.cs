using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class PAUSEMENU_dialogBox : MonoBehaviour
{
    public GameObject pause,pauseMenu;

    
    private int x;
    
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
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

        if(Input.GetKeyDown(KeyCode.JoystickButton9))
        {
            pauseMenu.SetActive(true);
            pause.SetActive(false);
        }
    }

    public void clickPaused()
    {   
        pauseMenu.SetActive(true);
        pause.SetActive(false);
        x = 0;
    }

    public void clickResume()
    {
        pauseMenu.SetActive(false);
        pause.SetActive(true); 
        x=1;    
    }
    public void clickMenu()
    {
        SceneManager.LoadScene("gameStart");
    }
}
