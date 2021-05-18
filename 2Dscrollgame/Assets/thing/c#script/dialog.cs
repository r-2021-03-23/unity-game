using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class dialog : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject continueButton;

    public Animator animator;

    void Start()
    {
        textDisplay.text = sentences[index];
        Time.timeScale = 0 ;
    }

    void Update()
    {    
        if(textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
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
