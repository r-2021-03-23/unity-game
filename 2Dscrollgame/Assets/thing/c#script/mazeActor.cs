using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mazeActor : MonoBehaviour
{
    public float speed = 5f;

    public int Qty_Pickup = 20;

    public Text Qty_Pickup_Remained;
    private Rigidbody2D Rigidbody;


    
    // Start is called before the first frame update
    public void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float X_Move = Input.GetAxis("Horizontal");
        float Y_Move = Input.GetAxis("Vertical");

        Vector2 Movement = new Vector2(X_Move, Y_Move);

        Rigidbody.AddForce(Movement * speed);


    }

    public void OnCollisionEnter2D(Collision2D BeHit)
    {
        if (BeHit.gameObject.CompareTag("apple"))
        {
            //Destroy(BeHit.gameObject);
            BeHit.gameObject.SetActive(false);
            Qty_Pickup = Qty_Pickup - 1;
            Qty_Pickup_Remained.text = Qty_Pickup.ToString();
        }
    }


}
