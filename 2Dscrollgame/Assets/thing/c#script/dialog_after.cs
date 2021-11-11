using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class dialog_after : MonoBehaviour
{
    public Text textDisplay;
    public string[] sentences;
    private int index;
   
    public Button pb;
 
    public GameObject enemy;
    public player p;
    public GameObject dialogBox;
    public GameObject continueButton;

    public Animator animator;

    Vector3 y;

    void Start()
    {
        animator.SetBool("IsOpen",false);
        
    }

    void Update()
    {    
        if(enemy.activeSelf == false)
        {
            animator.SetBool("IsOpen",true);
            textDisplay.text = sentences[index];
            Time.timeScale = 0;
        }
        if(index == sentences.Length-1)
        {
            continueButton.SetActive(false);
            animator.SetBool("IsOpen",false);
        }
        if(textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
        
        if(animator.GetBool("IsOpen") == true)
        {
            pb.GetComponent<Button>().interactable = false;
            p.transform.localPosition = y;
        }
        else
        {
            y = p.transform.localPosition;
            pb.GetComponent<Button>().interactable = true;
            Time.timeScale = 1;
        }
        if(Input.GetKeyDown(KeyCode.Joystick1Button1) || Input.GetKeyDown(KeyCode.Return))
        {
            NextSentence();
        }
    }


    public void NextSentence()
    {
        continueButton.SetActive(false);

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
            Time.timeScale = 1;
        }
    }
}
