using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikes : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Up",1,5);
        InvokeRepeating("Down",1,6);
    }

    void Up()
    {
        animator.SetBool("state",true);
    }
    void Down()
    {
        animator.SetBool("state",false);
    }
}


