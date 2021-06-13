using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Repeat",0,3);
        InvokeRepeating("repeat",0,2);
    }

    void Repeat()
    {
        this.gameObject.SetActive(false);
    }
    void repeat()
    {
        this.gameObject.SetActive(true);
    }
}


