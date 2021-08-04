using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletFromSky : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Camera cam;
    public Rigidbody2D rb;

    Vector2 mousePos,movement;
    // Start is called before the first frame update
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        Vector2 lookdir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookdir.y,lookdir.x)*Mathf.Rad2Deg - 90f;
        rb.rotation = angle;


    }   
}
