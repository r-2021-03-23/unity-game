using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class PAUSEMENU_dialogBox : MonoBehaviour
{
    public GameObject pause;

   
    private int x;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
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
  
        
    }

    public void clickPaused()
    {   
        gameObject.SetActive(true);
        pause.SetActive(false);
        Time.timeScale = 0f;
        x = 0;
    }

    public void clickResume()
    {
        gameObject.SetActive(false);
        pause.SetActive(true);
        Time.timeScale = 1f;  
        x=1;    
    }
    public void clickMenu()
    {
        SceneManager.LoadScene("gameStart");
    }
}
