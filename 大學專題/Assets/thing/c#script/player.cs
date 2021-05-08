using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    
    public Animator ani;
    public Rigidbody2D rb;
    public int hp = 0;
    public int max_hp = 0;
    public GameObject bulletPrefab;
    public Image hp_bar;
    public GameObject dialogBox;
    float horizontalMove = 0f;
    float speed = 3f;
    float jumpSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        max_hp = 10;
        hp = max_hp;
        
    }

    // Update is called once per frame
    void Update()
    { 
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        if(Input.GetButton("right"))
        {
            rb.velocity = new Vector2(speed,rb.velocity.y);
        }
        if(Input.GetButton("left") )
        {
            rb.velocity = new Vector2(-speed,rb.velocity.y);
        }
        ani.SetFloat("speed",Mathf.Abs(horizontalMove));

        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y == 0)
        {
            rb.AddForce(transform.up * jumpSpeed, ForceMode2D.Impulse);
            ani.SetBool("isJumping", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ani.SetBool("isJumping", false);
        }



        if(Input.GetKeyDown(KeyCode.X))
        {
            Instantiate(bulletPrefab, this.transform.position,Quaternion.identity);
        }

        hp_bar.transform.localScale = new Vector3((float)hp / (float)max_hp, 1, transform.localScale.z);

        
    }
        
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            hp -= 1;
        }
    }

    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("enemyBomb") )
        {
            hp -= 1;
            Destroy(other.gameObject);
        }
    }  


}
