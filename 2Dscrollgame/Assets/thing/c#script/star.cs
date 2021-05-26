using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class star : MonoBehaviour
{
    public Image[] images;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CardGameManager.f == 1)
        {
            images[0].color = Color.yellow;
        }
        if(mazeGameManager.m == 1)
        {
            images[1].color = Color.yellow;
        }    
    }

}
