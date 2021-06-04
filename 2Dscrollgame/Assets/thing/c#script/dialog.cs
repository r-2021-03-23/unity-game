using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class dialog : MonoBehaviour
{
    // Start is called before the first frame update
    public  Text textDisplay;
    public  string[] sentences;
    public int index;
    
    public GameObject pb;

    public GameObject continueButton;

    public Animator animator;


    void Start()
    {
        textDisplay.text = sentences[index];
    }

    void Update()
    {    
        if(textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
        if(animator.GetBool("IsOpen") == true)
        {
            pb.SetActive(false); 
            Time.timeScale = 0f;
        }
        if(animator.GetBool("IsOpen") == false)
        {
            pb.SetActive(true);
            Time.timeScale = 1f;
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
        
        }
    }
}
