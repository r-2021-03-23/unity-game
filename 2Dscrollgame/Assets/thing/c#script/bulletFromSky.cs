using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletFromSky : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Camera cam;
    public Rigidbody2D rb;
    float speed = 3f;
    
    float horizontalMove;
    // Start is called before the first frame update
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * speed;
        if(horizontalMove > 0 && Time.timeScale == 1)
        {
            rb.velocity = new Vector2(speed,rb.velocity.y);   
        }
        if(horizontalMove < 0 && Time.timeScale == 1 )
        {
            rb.velocity = new Vector2(-speed,rb.velocity.y);
            
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {


    }   
}
