using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    
    public Animator ani;
    public Rigidbody2D rb;
    public static int hp = 10;
    public int max_hp = 10;

    public GameObject gameOver;
    public GameObject pauseButton;
    public Image hp_bar;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    float horizontalMove = 0f;
    float speed = 3f;
    float jumpSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    { 
        if(hp > max_hp)
        {
            hp = max_hp;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            attack();
        }

        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        if(Input.GetButton("right") && Time.timeScale == 1)
        {
            rb.velocity = new Vector2(speed,rb.velocity.y);
            
            
        }
        if(Input.GetButton("left") && Time.timeScale == 1 )
        {
            rb.velocity = new Vector2(-speed,rb.velocity.y);
            
        }
            
        if(Time.timeScale == 1)
            ani.SetFloat("speed",Mathf.Abs(horizontalMove));

                
        
        if (Input.GetKeyDown(KeyCode.W) && rb.velocity.y == 0 && Time.timeScale == 1 )
        {
           
            rb.AddForce(transform.up * jumpSpeed, ForceMode2D.Impulse);
            ani.SetBool("isJumping", true);
            
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            ani.SetBool("isJumping", false);
                      
        }

        if(horizontalMove < 0 && Time.timeScale == 1)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if(horizontalMove > 0 && Time.timeScale == 1)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if(hp == 0)
        {
            Time.timeScale = 0;
            gameOver.SetActive(true);
            pauseButton.SetActive(false);
            hp = 10;
        }


        hp_bar.transform.localScale = new Vector3((float)hp / (float)max_hp, 1, transform.localScale.z);
        
    }
        
    

    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("enemyBomb") )
        {
            hp -= 1;
            Destroy(other.gameObject);
        }
        if(other.gameObject.CompareTag("cardGame"))
        {
            SceneManager.LoadScene("level1Card");
        }
        if(other.gameObject.CompareTag("mazeGame"))
        {
            SceneManager.LoadScene("level1Maze");
        }
    }  

    void attack()
    {
        ani.SetTrigger("Attack");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position,attackRange,enemyLayers);

        foreach(Collider2D enemy in hitEnemies)
        {
           enemy.GetComponent<enemy>().hp -= 1 ;
        }
    }

    void OnDrawGizmosSelected()
    {
        if(attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position,attackRange);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("ground"))
        {
            Time.timeScale = 0;
            gameOver.SetActive(true);
            pauseButton.SetActive(false);
        }
    }
}
