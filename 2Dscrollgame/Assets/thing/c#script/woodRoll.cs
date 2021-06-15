using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woodRoll : MonoBehaviour
{
    public float span = 10f,delta = 0;
    // Start is called before the first frame update
    public Rigidbody2D rb;

    public GameObject prefab;
    Vector3 pos;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pos = this.transform.position;
        
    }


    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector3(-1,0,0));
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {   
            this.delta = 0;
            Instantiate(prefab,pos,Quaternion.identity);
            Destroy(this.gameObject);
        }
            
        
    }
}
