using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class enemy : MonoBehaviour
{
    private int hp;
    public int max_hp=10;

    int  r;
    public GameObject hp_bar;
    public GameObject BulletPrefab;

    public Animator dialog;
    public player player;

    public float span = 0.5f,delta = 0;

    public GameObject potPrefab;

    public Image rageValue,release;

    public static float rageV;


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
            r = Random.Range (0,2);
            if(r == 0)
            {
                Instantiate(potPrefab,this.transform.position+new Vector3(0,0,0),Quaternion.identity);  
            }   
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
            rageValue.fillAmount += 0.1f;
        }
        if(other.gameObject.CompareTag("skill"))
        {
            hp -= 5;
            Destroy(other.gameObject);
        }
    }
}
