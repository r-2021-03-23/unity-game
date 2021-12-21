using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questionController : MonoBehaviour
{

    public Text text;
    public static int answerCorrect = 3;
    public int a = 0;
    public Image image;
    public Button[] button;

    
    // Start is called before the first frame update
    void Start()
    {
        answerCorrect = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(countDown.setTime == 0)
        {
            button[0].enabled = false;
            button[1].enabled = false;
            button[2].enabled = false;
            button[3].enabled = false;
        }
        if(a == 1)
        {
            button[0].enabled = false;
            button[1].enabled = false;
            button[2].enabled = false;
            button[3].enabled = false;
        }
        if(a == 0 && countDown.setTime == 0)
        {
            answerCorrect = 0;

        }
        if(Input.GetKeyDown(KeyCode.Joystick1Button3))
        {
            button[0].enabled = false;
            button[1].enabled = false;
            button[2].enabled = false;
            button[3].enabled = false;
            button[0].onClick.Invoke();
        }
        if(Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            button[0].enabled = false;
            button[1].enabled = false;
            button[2].enabled = false;
            button[3].enabled = false;
            button[1].onClick.Invoke();
        }
        if(Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            button[0].enabled = false;
            button[1].enabled = false;
            button[2].enabled = false;
            button[3].enabled = false;
            button[2].onClick.Invoke();
        }
        if(Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            button[0].enabled = false;
            button[1].enabled = false;
            button[2].enabled = false;
            button[3].enabled = false;
            button[3].onClick.Invoke();
        }


    } 
    public void MouseDown()
    {        
            if(GetComponent<isAnswer>().isAnswer1 == true)
            {
                this.image.color = Color.green;
                text.text = "Correct!";
                GetComponent<isClicked>().clicked = true;
                answerCorrect = 2;
            }
            if(GetComponent<isAnswer>().isAnswer1 == false)
            {
                this.image.color = Color.red;
                text.text = "false...";
                GetComponent<isClicked>().clicked = true;
                answerCorrect = 1;
            }
            
            
       a = 1;    
    }

}
