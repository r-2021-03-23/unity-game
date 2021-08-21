using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorCracked : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator ani;
    void Start()
    {
        ani.SetBool("stand",false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        ani.SetBool("stand",true);
    }

}
