using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class dialog_center : MonoBehaviour
{
    public Text textDisplay;
    public string[] sentences;
    private int index;

    public GameObject continueButton;
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
        if(Mathf.Abs(player.transform.localPosition.x - enemy.transform.localPosition.x) < 4 && Mathf.Abs(player.transform.localPosition.y - enemy.transform.localPosition.y) < 0.25)
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
            Time.timeScale = 1;
        }
    }
}
