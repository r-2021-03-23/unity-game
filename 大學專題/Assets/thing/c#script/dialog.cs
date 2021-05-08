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
        StartCoroutine(Type());
        
    }

    void Update()
    {    
        if(textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }

    }

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);

        if(index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
            animator.SetBool("IsOpen",false);
        }
    }
}
