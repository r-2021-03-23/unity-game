using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletFromSky : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Camera cam;
    public Rigidbody2D rb;
    float speed = 3f;
    Vector2 mousePos,movement;
    // Start is called before the first frame update
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        if(Input.GetButton("right") && Time.timeScale == 1)
        {
            rb.velocity = new Vector2(speed,rb.velocity.y);
            
            
        }
        if(Input.GetButton("left") && Time.timeScale == 1 )
        {
            rb.velocity = new Vector2(-speed,rb.velocity.y);
            
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 lookdir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookdir.y,lookdir.x)*Mathf.Rad2Deg - 90f;
        rb.rotation = angle;


    }   
}
