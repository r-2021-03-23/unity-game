using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikes1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Repeat",0,5);
        InvokeRepeating("repeat",0,3);
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
