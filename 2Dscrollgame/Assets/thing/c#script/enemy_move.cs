using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move : MonoBehaviour
{
    Vector3 nowPos;
    public Transform startPos,pos1,pos2;

    public Animator ani;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
       nowPos = startPos.position;       
    }

    // Update is called once per frame
    void Update()
    {
        
        float dis1 = Vector3.Distance(transform.position,pos1.position);
        
        float dis2 = Vector3.Distance(transform.position,pos2.position);

        if(dis1 < 0.5)
        {
            nowPos = pos2.position;
            ani.SetBool("right",true);       
        }
        if(dis2 < 0.5)
        {
            nowPos = pos1.position;
            ani.SetBool("right",false);
        }

        

        transform.position = Vector3.MoveTowards(transform.position,nowPos,speed*Time.deltaTime);
    }
}
