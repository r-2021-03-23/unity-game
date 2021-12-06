using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class enemy : MonoBehaviour
{
    public int hp;
    public int  max_hp=10;

    public GameObject hp_bar;
    public GameObject BulletPrefab;

    public Animator dialog;
    public player player;

    public float span = 0.5f,delta = 0;

    public Image rageValue,release;

    public static float rageV;

    public GameObject enemydeadspot;

    float x;
    public GameObject potPrefab;

    Vector3 oldtransform;
    // Start is called before the first frame update
    void Start()
    { 
        hp = max_hp; 
        oldtransform = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
         
        if(hp <= 0) 
        {   
           this.transform.position = enemydeadspot.transform.position;
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

        if(hp <= 0)
        {
            if(x == 0f) 
            {
                Instantiate(potPrefab,oldtransform+new Vector3(0,0,0),Quaternion.identity);
                x = 1f;
            }
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("playerBullet"))
        {   
            hp -= 1;
            Destroy(other.gameObject);
            rageValue.fillAmount += 0.1f;
        }
        if(other.gameObject.CompareTag("skill"))
        {
            hp -= 5;
            Destroy(other.gameObject);
        }
    }


}