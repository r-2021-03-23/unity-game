using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBulletSpeedAndLength : MonoBehaviour
{
    public  int r=0,x=0,y=1; 
    public static float delta = 0f,span = 1.5f;
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
        
        if(GetComponent<isAnswer>().isAnswer1 == true && GetComponent<isClicked>().clicked == true && y == 1)
        {
            r = Random.Range(0,2);
            if(r==0)
            {
                
                if(playerBullet.Length > 1.5)
                {//text.text = "射程已達上限";
                    x = 2;
                    playerBullet.Length = 1.5f;
                }
                else
                {   
                    //text.text = "射程增加";
                    x = 1;
                    playerBullet.Length += 0.1f;     
                }
            }
            if(r==1)
            {
                if(span < 0.1f)
                {
                    //text.text = "射速已達上限";
                    x = 4;
                    span = 0.1f;
                }
                else
                {   //text.text = "射速增加";
                    x = 3;
                    span -= 0.5f;
                    
                }
            }
            y=0;
        }
        if(GetComponent<isAnswer>().isAnswer1 == false && GetComponent<isClicked>().clicked == true)
        {
            x=5;
        }
 
    }
}
