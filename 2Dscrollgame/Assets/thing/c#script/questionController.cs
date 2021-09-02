using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questionController : MonoBehaviour
{

    public Text text;

    public int a = 0;
    public bool isAnswer;
    public Image image;
    public Button[] button;
    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {
        if(a == 1)
        {
            button[0].enabled = false;
            button[1].enabled = false;
            button[2].enabled = false;
            button[3].enabled = false;
        }
    } 
    public void MouseDown()
    {        
            if(isAnswer == true)
            {
                this.image.color = Color.green;
                text.text = "Correct!";
            }
            else
            {
                this.image.color = Color.red;
                text.text = "false...";
            }
        a = 1;    
    }

}
