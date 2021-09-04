using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBulletSpeedAndLength : MonoBehaviour
{
    public  int r=0,x=0,y=1; 
    public static float delta = 0f,span = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(delta > span)
            {
                delta = 0f;
                GetComponent<player>().attack();
            }     
        }
        
        if(GetComponent<isAnswer>().isAnswer1 == true && GetComponent<questionController>().clicked == true && y == 1)
        {
            r = Random.Range(0,2);
            if(r==0)
            {
                
                if(playerBullet.Length > 3)
                {//text.text = "射程已達上限";
                    x = 2;
                    playerBullet.Length = 3;
                }
                else
                {   
                    //text.text = "射程增加";
                    x = 1;
                    playerBullet.Length += 1f;     
                }
            }
            if(r==1)
            {
                if(delta < 0.1f)
                {
                    //text.text = "射速已達上限";
                    x = 4;
                    delta = 0.1f;
                }
                else
                {   //text.text = "射速增加";
                    x = 3;
                    delta -= 1f;
                    
                }
            }
            y=0;
        }
 
    }
}
