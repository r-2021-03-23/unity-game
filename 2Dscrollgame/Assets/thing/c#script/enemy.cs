using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private int hp;
    public int max_hp=10;

  
    public GameObject hp_bar;
    public GameObject BulletPrefab;

    public Animator dialog;
    public player player;

    public float span = 0.5f,delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
        hp = max_hp;   
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(hp <= 0)
        {
            this.gameObject.SetActive(false);
            player.hp += 3;
        }
        float percent = ((float)hp / (float)max_hp);
        hp_bar.transform.localScale = new Vector3(percent, hp_bar.transform.localScale.y, hp_bar.transform.localScale.z);

        if(dialog.GetBool("IsOpen") == false)
        {
            if(this.delta > this.span)
            {
                this.delta = 0;
                Instantiate(BulletPrefab,this.transform.position,Quaternion.identity);         
            }
        }   
     
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("playerBullet"))
        {   
            hp -= 1;
            Destroy(other.gameObject); 
        }
    }
}
