using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class countDown : MonoBehaviour
{
    public int setTime = 20;
    public Text countdown,TimesUp;
    public static int r;
    public bool start = true;
    Coroutine co;
    // Start is called before the first frame update
    void Start()
    {   
         
         co = StartCoroutine(count());
         r = QuestionThrough.r;
    }

    // Update is called once per frame
    void Update()
    {
       if(questionController.answerCorrect == 2 || questionController.answerCorrect == 1)
        {
            StopCoroutine(co);
        }
    }
    IEnumerator count()
    {
        while(setTime > 0)
        {
            countdown.text = "0:" + setTime.ToString();
            yield return new WaitForSeconds(1f);
            setTime--;

        }
   
    }


}
