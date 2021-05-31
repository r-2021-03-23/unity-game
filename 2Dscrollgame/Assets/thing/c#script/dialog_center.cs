using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class dialog_center : MonoBehaviour
{
    public Text textDisplay;
    public string[] sentences;
    public int index;

    public double x = 5 ,y = 0.25;
    public GameObject continueButton;

    public GameObject pauseButton;
    public player player;
    public enemy enemy;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("IsOpen",false);
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("x"+Mathf.Abs(player.transform.localPosition.x - enemy.transform.localPosition.x));
        Debug.Log("y"+Mathf.Abs(player.transform.localPosition.y - enemy.transform.localPosition.y));
        if(Mathf.Abs(player.transform.localPosition.x - enemy.transform.localPosition.x) < x && Mathf.Abs(player.transform.localPosition.y - enemy.transform.localPosition.y) < y && player.x == 1)
        {
            
            animator.SetBool("IsOpen",true);
            textDisplay.text = sentences[index];
            Time.timeScale = 0;    
        }

        if(index == sentences.Length-1)
        {
            continueButton.SetActive(false);
            animator.SetBool("IsOpen",false);
            Time.timeScale = 1;
        }
        if(textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
        if(animator.GetBool("IsOpen") == true)
        {
            pauseButton.SetActive(false);
        }
        else
        {
            pauseButton.SetActive(true);
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
