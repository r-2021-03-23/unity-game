using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class showInfo : MonoBehaviour
{
    public Text text;

    int r;
   
    // Start is called before the first frame update
    void Start()
    {  
        r = questionHandler.r;
    }

    // Update is called once per frame
    void Update()
    {
       
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
      
    }

    void wait()
    {
        SceneManager.UnloadSceneAsync(r+11);
    }


    
}
