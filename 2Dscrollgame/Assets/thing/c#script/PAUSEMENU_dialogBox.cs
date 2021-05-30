using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PAUSEMENU_dialogBox : MonoBehaviour
{
    public GameObject pause;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void clickPaused()
    {   
        gameObject.SetActive(true);
        pause.SetActive(false);
        Time.timeScale = 0;
    }

    public void clickResume()
    {
        gameObject.SetActive(false);
        pause.SetActive(true);
        Time.timeScale = 1;       
    }
    public void clickMenu()
    {
        SceneManager.LoadScene("gameStart");
    }
}
