using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
        }
        else if(GetComponent<playerBulletSpeedAndLength>().x == 3)
        {
            text.text = "射速增加";
        }
        else if(GetComponent<playerBulletSpeedAndLength>().x == 2)
        {
            text.text = "射程已達上限";
        }else if(GetComponent<playerBulletSpeedAndLength>().x == 1)
        {
            text.text = "射程增加";
        }
        else
        {
            text.text = " ";
        }
    }

    
}
