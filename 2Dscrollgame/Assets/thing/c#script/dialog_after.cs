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

    public GameObject dialogBox;
    public GameObject continueButton;

    public Animator animator;

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
            Time.timeScale = 0;
        }
        else
        {
            pb.GetComponent<Button>().interactable = true;
            Time.timeScale = 1; 
        }
        if(Input.GetKeyDown(KeyCode.Return))
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
