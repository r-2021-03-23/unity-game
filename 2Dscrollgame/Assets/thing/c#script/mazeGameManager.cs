using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class mazeGameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public string nextScene,stayScene;
    public GameObject textDisplay;

    public GameObject pause;
    public GameObject button,button1;
    public static int m=0;
    public Text text;
    public mazeActor actor;
    public int minutesleft = 2;
    public int secondsleft = 0;

    public bool takingAway;
    void Start()
    {
        secondsleft = minutesleft*60 + secondsleft;
        button.SetActive(false);
        button1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(takingAway == false && secondsleft > 0)
        {
            StartCoroutine(TimeTake());
        }
        if(secondsleft > 0 && actor.Qty_Pickup == 0)
        {
            text.text = "you win ! go to next level";
            button.SetActive(true);
            pause.SetActive(false);
            m = 1;
            Time.timeScale = 0;
        }
        if(secondsleft == 0 && actor.Qty_Pickup > 0)
        {
            text.text = "you lose ! stay at this level";
            button1.SetActive(true);
            pause.SetActive(false);
            Time.timeScale = 0;
        }
    }

    public void buttonClick()
    {
        SceneManager.LoadScene(nextScene);
    }
    public void button1Click()
    {
        SceneManager.LoadScene(stayScene);
    }
    IEnumerator TimeTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1f);
        
        secondsleft -= 1;
        if(secondsleft >= 60)
            textDisplay.GetComponent<Text>().text = "1:" + secondsleft%60;
        else 
            textDisplay.GetComponent<Text>().text = "0:" + secondsleft%60;
        takingAway = false;
    }
}
