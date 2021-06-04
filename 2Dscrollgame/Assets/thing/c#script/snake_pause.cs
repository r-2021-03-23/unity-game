using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class snake_pause : MonoBehaviour
{
    // Start is called before the first frame update
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
        Time.timeScale = 0.06f;
        gameObject.SetActive(false);
        pause.SetActive(true);
        
    }

    public void clickMenu()
    {
        SceneManager.LoadScene("gameStart");
    }
}
