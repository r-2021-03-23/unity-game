using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class playerFinal : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator ani;

    public Text gameFinish;

    float horizontalMove,speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * speed;
       
        
        if(horizontalMove > 0 && Time.timeScale == 1)
        {
            rb.velocity = new Vector2(speed,rb.velocity.y);
            
            
        }

        if(horizontalMove < 0 && Time.timeScale == 1)
        {
            rb.velocity = new Vector2(-speed,rb.velocity.y);
        }
        
        if(horizontalMove < 0 && Time.timeScale == 1 )
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if(horizontalMove > 0 && Time.timeScale == 1)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if(Time.timeScale == 1)
            ani.SetFloat("speed",Mathf.Abs(horizontalMove));
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "final")
        {
            gameFinish.text = "Game Finish!";
            Invoke("backToLevel",5f);
        }
    }

    void backToLevel()
    {
        SceneManager.LoadScene("gameStart");
    }
}
