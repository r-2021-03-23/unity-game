using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class finalDialogCenter : MonoBehaviour
{
    public Text textDisplay;
    public string[] sentences;
    public int index;

    public double x = 5 ,y = 0.25;
    public GameObject continueButton;


    public GameObject player;

    public  GameObject princess;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("IsOpen",false);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("x"+Mathf.Abs(player.transform.localPosition.x - princess.transform.localPosition.x));
        //Debug.Log("y"+Mathf.Abs(player.transform.localPosition.y - princess.transform.localPosition.y));
        if(Mathf.Abs(player.transform.localPosition.x - princess.transform.localPosition.x) < x && Mathf.Abs(player.transform.localPosition.y - princess.transform.localPosition.y) < y)
        {
            
            animator.SetBool("IsOpen",true);
            textDisplay.text = sentences[index];
            Time.timeScale = 0f;    
        }

        if(animator.GetBool("IsOpen") == true)
        {
            Time.timeScale = 0f;
        }
        else
        {
           Time.timeScale = 1f;
        }


        if(index == sentences.Length-1)
        {
            continueButton.SetActive(false);
            animator.SetBool("IsOpen",false);
            Time.timeScale = 1f;
        }
        if(textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.Joystick1Button1) || Input.GetKeyDown(KeyCode.Return))
        {
            NextSentence();
        }
    } 

    public void NextSentence()
    {
        
        if(index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = sentences[index];
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
            animator.SetBool("IsOpen",false);
           
        }
    }
}
