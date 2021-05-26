using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBulletController_glove : MonoBehaviour
{

    float x,y;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x=-0.3f*Time.deltaTime*60;
        y=-0.1f*Time.deltaTime*60;
        this.transform.position += new Vector3(x,y, 0);
        timer -= Time.deltaTime;            
        if(timer <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
