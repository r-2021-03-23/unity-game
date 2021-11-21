using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player : MonoBehaviour
{
  

    public Animator ani;
    public Rigidbody2D rb;
    public static float hp = 10;
    public float max_hp = 10;

    public static bool isGameOver;
    bool isGround;
    
    
    public static int x=0,xy = 0;

    
    public GameObject BulletPrefab;
    
    public GameObject gameOver;
    public GameObject pauseButton;
    public Image hp_bar,hurt;

    
    public Animator[] animators;
   
    public static bool CanPlay = true;
   
    float horizontalMove = 0f;
    float speed = 3f;
    float jumpSpeed = 10f,hurtSpeed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    { 
        for(int i =0;i<animators.Length;i++)
        {
            if(animators[i].GetBool("IsOpen") == true)
            {
                if(i==0)
                {
                    this.gameObject.GetComponent<Animator>().enabled = false;
                    this.transform.position = new Vector3(-13,-1,0);  
                }

            }
            else
            {
                this.gameObject.GetComponent<Animator>().enabled = true;
                
            }
        }
        if(hp > max_hp)
        {
            hp = max_hp;
        }

        horizontalMove = Input.GetAxis("Horizontal") * speed;
       
        
        if(horizontalMove > 0 && Time.timeScale == 1 && CanPlay == true && horizontalMove > 0)
        {
            rb.velocity = new Vector2(speed,rb.velocity.y);
            
            
        }

        if(horizontalMove < 0 && Time.timeScale == 1 && CanPlay == true && horizontalMove < 0)
        {
            rb.velocity = new Vector2(-speed,rb.velocity.y);
        }


        if(Time.timeScale == 1)
            ani.SetFloat("speed",Mathf.Abs(horizontalMove));

                
        
        if ((Input.GetKeyDown(KeyCode.Joystick1Button0) || Input.GetKeyDown(KeyCode.W)) && isGround == true && Time.timeScale == 1 && CanPlay == true)
        {
           
            rb.AddForce(transform.up * jumpSpeed, ForceMode2D.Impulse);
            ani.SetBool("isJumping", true); 
        }
        if((Input.GetKeyDown(KeyCode.Joystick1Button0) || Input.GetKeyDown(KeyCode.W)))
        {
            ani.SetBool("isJumping", false); 
        }


        if(horizontalMove < 0 && Time.timeScale == 1 )
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if(horizontalMove > 0 && Time.timeScale == 1)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if(hp == 0)
        {
            Time.timeScale = 0f;
            gameOver.SetActive(true);
            pauseButton.SetActive(false);
            hp = 10;
        }
        else
        {
            Time.timeScale = 1f;
        }
        if(gameOver.activeSelf == true)
        {
            hp = 10;
        }
        hp_bar.fillAmount = hp/max_hp;
        if(hurt.fillAmount > hp_bar.fillAmount)
        {
            hurt.fillAmount -= 0.001f;
        }
        else
        {
            hurt.fillAmount = hp_bar.fillAmount;
        }

        if (CanPlay == false)
        {
            speed = 0f;
            jumpSpeed = 0f;
        }

        if (CanPlay == true)
        {
            speed = 3f;
            jumpSpeed = 10f;
        }
}
        
    

    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("enemyBomb") )
        {
            hp -= 1;
            Destroy(other.gameObject);
        }
        if(other.gameObject.CompareTag("enemyBomb1"))
        {
            Destroy(other.gameObject);
            hp -= 1;

        }
        if(other.gameObject.CompareTag("下一關1"))
        {
            xy = 2;
            GetComponent<loadLevel>().LoadLevel();
        }
        if(other.gameObject.CompareTag("下一關2"))
        {
            xy = 3;
            GetComponent<loadLevel>().LoadLevel();
        }
        if(other.gameObject.CompareTag("下一關3"))
        {
             xy = 4;
            GetComponent<loadLevel>().LoadLevel();
        }
        if(other.gameObject.CompareTag("下一關4"))
        {
             xy = 5;
            GetComponent<loadLevel>().LoadLevel();
        }
        if(other.gameObject.CompareTag("下一關5"))
        { 
            xy = 6;
            GetComponent<loadLevel>().LoadLevel();
        }
        if(other.gameObject.CompareTag("下一關6"))
        {
             xy = 7;
            GetComponent<loadLevel>().LoadLevel();
        }
        if(other.gameObject.CompareTag("下一關7"))
        {
             xy = 8;
            
            GetComponent<loadLevel>().LoadLevel();
        }
        if(other.gameObject.CompareTag("下一關8"))
        {
            xy = 9;
            GetComponent<loadLevel>().LoadLevel();
        }
        if(other.gameObject.CompareTag("下一關9"))
        {
            xy = 10;
            GetComponent<loadLevel>().LoadLevel();
        }
    }  
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("ground"))
        {
            isGameOver = true;
            gameOver.SetActive(true);
            pauseButton.SetActive(false);
        }
        if(col.gameObject.CompareTag("floor"))
        {
            x=1;
        }
        if(col.gameObject.CompareTag("spike"))
        {
            hp -= 1;
            rb.AddForce(transform.up * hurtSpeed, ForceMode2D.Impulse);
            ani.SetBool("isJumping", true);
        }
        if(col.gameObject.CompareTag("floor") || col.gameObject.CompareTag("mainfloor"))
        {
            isGround = true;
        } 
        if(col.gameObject.CompareTag("healthPot"))
        {
            hp += 3;
            col.gameObject.SetActive(false);
        } 
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("floor"))
        {
            x=0;
        }
        if(col.gameObject.CompareTag("spike"))
        {
            ani.SetBool("isJumping", false);
        }
        if(col.gameObject.CompareTag("floor") || col.gameObject.CompareTag("mainfloor"))
        {
            isGround = false;
        }
    }


    public void attack()
    {
        Instantiate(BulletPrefab,this.transform.position+new Vector3(0,0,0),Quaternion.identity); 
    }
    
}
