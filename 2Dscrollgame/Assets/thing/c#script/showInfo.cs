using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class showInfo : MonoBehaviour
{
    public Text text;

     
    
     public static int a,r;   
   
    // Start is called before the first frame update
    void Start()
    {  
        r = QuestionThrough.r;
    
    }

    // Update is called once per frame
    void Update()
    {

       a = 0; 
       if(GetComponent<playerBulletSpeedAndLength>().x == 4)
        {
            text.text = "射速已達上限";
            Invoke("wait",5f);
        }
        else if(GetComponent<playerBulletSpeedAndLength>().x == 3)
        {
            text.text = "射速增加";
            Invoke("wait",5f);
        }
        else if(GetComponent<playerBulletSpeedAndLength>().x == 2)
        {
            text.text = "射程已達上限";
            Invoke("wait",5f);
        }
        else if(GetComponent<playerBulletSpeedAndLength>().x == 1)
        {
            text.text = "射程增加";
            Invoke("wait",5f);
        }
        else if(GetComponent<playerBulletSpeedAndLength>().x == 5)
        {
            Invoke("wait",5f);
        }
        else if(GetComponent<playerBulletSpeedAndLength>().x == 6)
        {
             Invoke("wait",5f);
        }
        
    }

    void wait()
    {
        SceneManager.UnloadSceneAsync(r+11);
        player.CanPlay = true;
    }


    
}
