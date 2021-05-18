using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PAUSEMENU_LEVEL1SIMPLE : MonoBehaviour
{
    public GameObject pause;

    public int index;
    public dialog dialog;
    public GameObject dialogBox;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        pause.SetActive(true);
        dialogBox.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void clickPaused()
    {
        gameObject.SetActive(true);
        pause.SetActive(false);
        if(dialogBox.activeSelf == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 0;
        }
        dialogBox.SetActive(false);
        
    }

    public void clickResume()
    {
        gameObject.SetActive(false);
        pause.SetActive(true);
        if(dialog.textDisplay.text == dialog.sentences[index])
        {
            dialogBox.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {
            dialogBox.SetActive(true);
            Time.timeScale = 0;
        }

    }
    public void clickMenu()
    {
        SceneManager.LoadScene("gameStart");
    }
}
