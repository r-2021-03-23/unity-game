using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int hp = 0;
    public int max_hp = 0;
    public GameObject hp_bar;
    public GameObject BulletPrefab;

    public player player;

    public float span = 0.5f,delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        max_hp = 5;
        hp = max_hp;
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(hp <= 0)
        {
            Destroy(this.gameObject);
            player.hp += 3;
        }
        float percent = ((float)hp / (float)max_hp);
        hp_bar.transform.localScale = new Vector3(percent, hp_bar.transform.localScale.y, hp_bar.transform.localScale.z);
            
        if(this.delta > this.span)
        {
            this.delta = 0;
            Instantiate(BulletPrefab,this.transform.position,Quaternion.identity);         
        }
        


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("sword") && Input.GetKeyDown(KeyCode.Space))
        {
            hp -= 1;
        }
        
    }  
}
