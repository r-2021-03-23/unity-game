using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class showInfo : MonoBehaviour
{
    public Text text;
   
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       
       if(GetComponent<playerBulletSpeedAndLength>().x == 4)
        {
            text.text = "射速已達上限";
            Invoke("wait",8f);
        }
        else if(GetComponent<playerBulletSpeedAndLength>().x == 3)
        {
            text.text = "射速增加";
            Invoke("wait",8f);
        }
        else if(GetComponent<playerBulletSpeedAndLength>().x == 2)
        {
            text.text = "射程已達上限";
            Invoke("wait",8f);
        }
        else if(GetComponent<playerBulletSpeedAndLength>().x == 1)
        {
            text.text = "射程增加";
            Invoke("wait",8f);
        }
        else
        {
            text.text = " ";
        }
    }

    void wait()
    {
        SceneManager.LoadScene(sceneHis.sceneHistory.Count - 1);
    }


    
}
