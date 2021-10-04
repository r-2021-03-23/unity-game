using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class star : MonoBehaviour
{
    public Image[] images;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0;i<images.Length;i++)
        {
            if(questionController.answerCorrect == 2)
            {
                if(QuestionThrough.through[QuestionThrough.y] == true)
                {
                    images[QuestionThrough.y].color = Color.green;
                }
               
                
            }
            if(questionController.answerCorrect == 1)
            {
                if(QuestionThrough.through[QuestionThrough.y] == true)
                {
                    images[QuestionThrough.y].color = Color.red;
                }
            }
        }
   
    }


}
